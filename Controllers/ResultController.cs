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
    public class ResultController : ControllerBase
    {
        GreatChemistContext db;
        IWebHostEnvironment _appEnvironment;

        public ResultController(GreatChemistContext context, IWebHostEnvironment appEnvironment)
        {
            this.db = context;
            _appEnvironment = appEnvironment;
        }

        [HttpGet("[action]")]
        public IEnumerable<Iteration> getUserIterations(string email)
        {
            return db.Iterations
                .Where(a => a.Email == email && !a.Deleted)
                .OrderByDescending(a => a.Date)
                .ToList();
        }

        [HttpGet("[action]")]
        public void getUserResults(int iteration)
        {
            List<UserResultsDTO> res = new List<UserResultsDTO>();
            UserResultsDTO newres = new UserResultsDTO();

            List<UserAnswersType1withRightsExt> res1 = db.UserAnswersType1withRightsExt.Where(a => a.IterationId == iteration).ToList();

            List<UserAnswersType1withRightsExt> res11 = res1.Where(a => a.Number == 1).ToList();
            newres.Parallel = res11[0].Parallel;
            newres.Mistakes = res11.Where(a => a.RightBtn != a.UserAnswer).Count();
            newres.Number = res11[0].Number;
            newres.OfficialNumber = res11[0].OfficialNumber;
            newres.StartTime = res11[0].StartTime;
            newres.EndTime = res11[0].EndTime;
            res.Add(newres);

            List<UserAnswersType1withRightsExt> res12 = res1.Where(a => a.Number == 2).ToList();
            newres.Parallel = res12[0].Parallel;
            newres.Mistakes = res12.Where(a => a.RightBtn != a.UserAnswer).Count();
            newres.Number = res12[0].Number;
            newres.OfficialNumber = res12[0].OfficialNumber;
            newres.StartTime = res12[0].StartTime;
            newres.EndTime = res12[0].EndTime;
            res.Add(newres);

            List<UserAnswersType1withRightsExt> res13 = res1.Where(a => a.Number == 3).ToList();
            newres.Parallel = res13[0].Parallel;
            newres.Mistakes = res13.Where(a => a.RightBtn != a.UserAnswer).Count();
            newres.Number = res13[0].Number;
            newres.OfficialNumber = res13[0].OfficialNumber;
            newres.StartTime = res13[0].StartTime;
            newres.EndTime = res13[0].EndTime;
            res.Add(newres);

            List<UserAnswersType2withRightsExt> res2 = db.UserAnswersType2withRightsExt.Where(a => a.IterationId == iteration).ToList();
            newres.Parallel = res2[0].Parallel;
            newres.Mistakes = res2.Where(a => a.RightBtn != a.UserAnswer).Count();
            newres.Number = res2[0].Number;
            newres.OfficialNumber = res2[0].OfficialNumber;
            newres.StartTime = res2[0].StartTime;
            newres.EndTime = res2[0].EndTime;
            res.Add(newres);

            List<UserAnswersType3withRightsExt> res3 = db.UserAnswersType3withRightsExt.Where(a => a.IterationId == iteration).ToList();
            newres.Parallel = res2[0].Parallel;
            newres.Mistakes = res2.Where(a => a.RightBtn != a.UserAnswer).Count();
            newres.Number = res2[0].Number;
            newres.OfficialNumber = res2[0].OfficialNumber;
            newres.StartTime = res2[0].StartTime;
            newres.EndTime = res2[0].EndTime;
            res.Add(newres);

            IEnumerable<UserAnswersType4withRightsExt> res4 = db.UserAnswersType4withRightsExt.Where(a => a.IterationId == iteration).ToList();
            IEnumerable<UserAnswersType6withRightsExt> res6 = db.UserAnswersType6withRightsExt.Where(a => a.IterationId == iteration).ToList();
        }
    }
}
