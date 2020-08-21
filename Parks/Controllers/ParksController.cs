using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;

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
    [HttpGet("{id}")]
    public ActionResult<string> GetById(int id)
    {
      var thisPark = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      string json = JsonSerializer.Serialize(thisPark);

      return json;
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

    [AllowAnonymous]
    [HttpGet("random")]
    public ActionResult<string> Random()
    {
      int max = _db.Parks.OrderByDescending(entry => entry.ParkId).FirstOrDefault().ParkId;
      Random rnd = new Random();
      int randId = rnd.Next(0, max);

      var randomPark = _db.Parks.FirstOrDefault(park => park.ParkId == randId);
      string json = JsonSerializer.Serialize(randomPark);

      return json;
    }
  }
}