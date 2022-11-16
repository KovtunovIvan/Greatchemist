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

        [HttpGet("[action]")]
        public IEnumerable<UserDTO> GetUsers()
        {
            IEnumerable<User> users = db.Users
                .Where(a => !a.Deleted)
                .OrderBy(a => a.GroupId)
                .OrderBy(a => a.Name)
                .ToList();
            IEnumerable<UserDTO> result = users
                .Select(c =>
                     new UserDTO
                     {
                         Id = c.Id,
                         Email = c.Email,
                         Name = c.Name,
                         GroupId = c.GroupId,
                         IsTeacher = c.IsTeacher,
                         IsManager = c.IsManager,
                         Deleted = c.Deleted,
                     });
            return result;
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
        public IActionResult ChangeUser([FromBody] User user)
        {
            User u = db.Users.Find(user.Id);
            u.IsManager = user.IsManager;
            u.IsTeacher = user.IsTeacher;
            u.Deleted = user.Deleted;
            db.Update(u);
            db.SaveChanges();
            return Ok(user);
        }

        [HttpPost("[action]")]
        public IActionResult Authorization([FromBody] AuthorizationUserDTO user)
        {
            List<User> users = db.Users.Where(a => !a.Deleted && a.Email == user.Email && a.Password == user.Password).ToList();
            if (users.Count() > 0)
            {
                return Ok(new { isAuthorized = true, isTeacher = users[0].IsTeacher, isManager = users[0].IsManager });
            }
            return Ok(new { isAuthorized = false, isTeacher = false, isManager = false });
        }
    }
}
