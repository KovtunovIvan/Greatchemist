using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tmp.Models;

namespace Tmp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        GreatChemistContext db;
        IWebHostEnvironment _appEnvironment;

        public UserController(GreatChemistContext context, IWebHostEnvironment appEnvironment)
        {
            this.db = context;
            _appEnvironment = appEnvironment;
        }

        //[HttpGet("[action]")]
        //public IEnumerable<User> GetUsers()
        //{
        //    return db.Users
        //        .Where(a => !a.Deleted)
        //        .OrderBy(a => a.Patronymic)
        //        .OrderBy(a => a.Name)
        //        .OrderBy(a => a.Surname)
        //        .ToList();
        //}

        [HttpGet("[action]")]
        public bool IsAdmin(string password)
        {
            return password == "GC2022" ? true : false;
        }

        [HttpPost("[action]")]
        public IActionResult AddUser([FromBody] User user)
        {
            if(db.Users.Where(a => !a.Deleted).Where(a => a.Email == user.Email).Count() == 0)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return Ok(user);
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public IActionResult Authorization([FromBody] AuthorizationUserDTO user)
        {
            if (db.Users.Where(a => !a.Deleted && a.Email == user.Email && a.Password == user.Password).Count() > 0)
            {
                return Ok(true);
            }
            return Ok(false);
        }
    }
}
