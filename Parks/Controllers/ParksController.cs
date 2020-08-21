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
    public ActionResult<IEnumerable<Park>> Get(string name)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }

      return query.ToList();
    }
  }
}