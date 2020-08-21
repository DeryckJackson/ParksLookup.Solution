using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Parks.Controllers
{
  [Authorize]
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private ParksContext _db;

    public ParksController(ParksContext db)
    {
      _db = db;
    }

    [AllowAnonymous]
    [HttpGet]
    public ActionResult<IEnumerable<Park>> GetAll()
    {
      return _db.Parks.ToList();
    }

    [AllowAnonymous]
    [HttpGet("search")]
    public ActionResult<IEnumerable<Park>> Search(string name, string city, string state, string zipcode)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City.Contains(city));
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State.Contains(state));
      }

      if (zipcode != null)
      {
        query = query.Where(entry => entry.Zipcode.Contains(zipcode));
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}