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
    public class GroupController : ControllerBase
    {
        GreatChemistContext db;
        IWebHostEnvironment _appEnvironment;

        public GroupController(GreatChemistContext context, IWebHostEnvironment appEnvironment)
        {
            this.db = context;
            _appEnvironment = appEnvironment;
        }

        [HttpGet("[action]")]
        public IEnumerable<Group> GetGroups()
        {
            return db.Groups
                .Where(a => !a.Deleted)
                .OrderBy(a => a.Title)
                .ToList();
        }

        [HttpGet("[action]")]
        public IEnumerable<Group> GetTeacherGroups(string email)
        {
            return db.Groups
                .Where(a => !a.Deleted && a.Email == email)
                .OrderBy(a => a.Title)
                .ToList();
        }
        

        [HttpPost("[action]")]
        public IActionResult AddGroup([FromBody] Group group)
        {
            if (db.Groups.Where(a => !a.Deleted).Where(a => a.Title == group.Title).Count() == 0)
            {
                db.Groups.Add(group);
                db.SaveChanges();
                return Ok(group);
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public IActionResult DeleteGroup([FromBody] Group group)
        {
            Group g = db.Groups.Find(group.Id);
            g.Deleted = true;
            db.Update(g);

            IEnumerable<User> users = db.Users.Where(a => a.GroupId == group.Id && !a.Deleted).ToList();
            foreach(User u in users)
            {
                u.Deleted = true;
                db.Update(g);
            }

            db.SaveChanges();
            return Ok();
        }
    }
}
