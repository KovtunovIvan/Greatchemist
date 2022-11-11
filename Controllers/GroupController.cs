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
    }
}
