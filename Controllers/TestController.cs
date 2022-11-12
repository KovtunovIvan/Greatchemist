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
    public class TestController : ControllerBase
    {
        GreatChemistContext db;
        IWebHostEnvironment _appEnvironment;

        public TestController(GreatChemistContext context, IWebHostEnvironment appEnvironment)
        {
            this.db = context;
            _appEnvironment = appEnvironment;
        }

        [HttpPost("[action]")]
        public IActionResult StartTest([FromBody] AuthorizationUserDTO user)
        {
            Iteration i = new Iteration();
            i.Email = user.Email;
            i.Deleted = false;
            i.Date = DateTime.Now;
            db.Iterations.Add(i);
            db.SaveChanges();
            return Ok(i.Id);
        }

        [HttpPost("[action]")]
        public IActionResult addAnswers([FromBody] UserAnswerType1DTO user)
        {
            int IterationId = 0;
            int Parallel = 0;
            int Task = user.Task;

            foreach (UserAnswerType1 ans in user.Answers)
            {
                db.UserAnswersType1.Add(ans);
                IterationId = ans.IterationId;
                Parallel = ans.Parallel;
            }

            TaskTime tt = new TaskTime();
            tt.IterationId = IterationId;
            tt.Parallel = Parallel;
            tt.TaskId = Task;
            tt.StartTime = user.StartTime;
            tt.EndTime = user.EndTime;
            db.TaskTimes.Add(tt);

            db.SaveChanges();

            int RightCount = db.UserAnswersType1withRights
                .Where(a => a.IterationId == IterationId &&
                a.Parallel == Parallel &&
                a.Task == Task &&
                a.UserAnswer == a.RightBtn).Count();

            return Ok(RightCount);
        }

        [HttpGet("[action]")]
        public Models.Task GetTask(int id)
        {
            return db.Tasks.Find(id);
        }

        [HttpGet("[action]")]
        public IEnumerable<QuestionType1DTO> GetQuestionsType1(int task)
        {
            IEnumerable<QuestionType1> questions = db.QuestionsType1
                .Where(a => a.Task == task && !a.Deleted).ToList();
            IEnumerable<QuestionType1DTO> result = questions
                .Select(c =>
                     new QuestionType1DTO
                     {
                         Id = c.Id,
                         QuestionLink = c.QuestionLink,
                         Btn1 = c.Btn1,
                         Btn2 = c.Btn2,
                         Task = c.Task
                     });
            return result;
        }
    }
}
