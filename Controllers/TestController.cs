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
        public IActionResult addAnswersType1([FromBody] UserAnswerType1DTO user)
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

        [HttpPost("[action]")]
        public IActionResult addAnswersType2([FromBody] UserAnswerType2DTO user)
        {
            int IterationId = 0;
            int Parallel = 0;
            int Task = user.Task;

            foreach (UserAnswerType2 ans in user.Answers)
            {
                db.UserAnswersType2.Add(ans);
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

            int RightCount = db.UserAnswersType2withRights
                .Where(a => a.IterationId == IterationId &&
                a.Parallel == Parallel &&
                a.Task == Task &&
                a.UserAnswer == a.RightBtn).Count();

            return Ok(RightCount);
        }

        [HttpPost("[action]")]
        public IActionResult addAnswersType3([FromBody] UserAnswerType3DTO user)
        {
            int IterationId = 0;
            int Parallel = 0;
            int Task = user.Task;

            foreach (UserAnswerType3 ans in user.Answers)
            {
                db.UserAnswersType3.Add(ans);
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

            int RightCount = db.UserAnswersType3withRights
                .Where(a => a.IterationId == IterationId &&
                a.Parallel == Parallel &&
                a.Task == Task &&
                a.UserAnswer == a.RightBtn).Count();

            return Ok(RightCount);
        }

        [HttpPost("[action]")]
        public IActionResult addAnswersType4([FromBody] UserAnswerType4DTO user)
        {
            int IterationId = 0;
            int Parallel = 0;
            int Task = user.Task;

            foreach (UserAnswerType4 ans in user.Answers)
            {
                db.UserAnswersType4.Add(ans);
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

            int RightCount = db.UserAnswersType4withRights
                .Where(a => a.IterationId == IterationId &&
                a.Parallel == Parallel &&
                a.Task == Task &&
                a.UserAnswer == a.RightBtn).Count();

            return Ok(RightCount);
        }

        [HttpPost("[action]")]
        public IActionResult addAnswersType5([FromBody] UserAnswerType5DTO user)
        {
            TaskTime tt = new TaskTime();
            tt.IterationId = user.IterationId;
            tt.Parallel = user.Parallel;
            tt.TaskId = user.Task;
            tt.StartTime = user.StartTime;
            tt.EndTime = user.EndTime;
            db.TaskTimes.Add(tt);
            db.SaveChanges();
            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult addAnswersType6([FromBody] UserAnswerType6DTO user)
        {
            int IterationId = 0;
            int Parallel = 0;
            int Task = user.Task;

            foreach (UserAnswerType6 ans in user.Answers)
            {
                db.UserAnswersType6.Add(ans);
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

            int RightCount = db.UserAnswersType6withRights
                .Where(a => a.IterationId == IterationId &&
                a.Parallel == Parallel &&
                a.Task == Task &&
                a.UserAnswer1 == a.Right1 &&
                a.UserAnswer2 == a.Right2 &&
                a.UserAnswer3 == a.Right3).Count();

            return Ok(RightCount);
        }

        [HttpGet("[action]")]
        public Models.Task GetTask(int id)
        {
            return db.Tasks.Find(id);
        }

        [HttpGet("[action]")]
        public IEnumerable<QuestionType1DTO> GetQuestionsType1(int task, int count)
        {
            IEnumerable<QuestionType1> questions = db.QuestionsType1
                .Where(a => a.Task == task && !a.Deleted).ToList();
            DateTime date = DateTime.Now;
            if(date.Millisecond % 2 == 0)
            {
                if(date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.QuestionLink).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.QuestionLink).Take(count).ToList();
                }
            }
            else
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.RightBtn).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.RightBtn).Take(count).ToList();
                }
            }
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

        [HttpGet("[action]")]
        public IEnumerable<QuestionType2DTO> GetQuestionsType2(int task, int count)
        {
            IEnumerable<QuestionType2> questions = db.QuestionsType2
                .Where(a => a.Task == task && !a.Deleted).ToList();
            DateTime date = DateTime.Now;
            if (date.Millisecond % 2 == 0)
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.QuestionLink).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.QuestionLink).Take(count).ToList();
                }
            }
            else
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.RightBtn).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.RightBtn).Take(count).ToList();
                }
            }
            IEnumerable<QuestionType2DTO> result = questions
                .Select(c =>
                     new QuestionType2DTO
                     {
                         Id = c.Id,
                         QuestionLink = c.QuestionLink,
                         Btn1 = c.Btn1,
                         Btn2 = c.Btn2,
                         Btn3 = c.Btn3,
                         Btn4 = c.Btn4,
                         Task = c.Task
                     });
            return result;
        }

        [HttpGet("[action]")]
        public IEnumerable<QuestionType3DTO> GetQuestionsType3(int task, int count)
        {
            IEnumerable<QuestionType3> questions = db.QuestionsType3
                .Where(a => a.Task == task && !a.Deleted).ToList();
            DateTime date = DateTime.Now;
            if (date.Millisecond % 2 == 0)
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.QuestionLink).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.QuestionLink).Take(count).ToList();
                }
            }
            else
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.RightBtn).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.RightBtn).Take(count).ToList();
                }
            }
            IEnumerable<QuestionType3DTO> result = questions
                .Select(c =>
                     new QuestionType3DTO
                     {
                         Id = c.Id,
                         QuestionLink = c.QuestionLink,
                         Btn1 = c.Btn1,
                         Btn2 = c.Btn2,
                         Btn3 = c.Btn3,
                         Btn4 = c.Btn4,
                         Btn5 = c.Btn5,
                         Btn6 = c.Btn6,
                         Btn7 = c.Btn7,
                         Btn8 = c.Btn8,
                         Btn9 = c.Btn9,
                         Btn10 = c.Btn10,
                         Btn11 = c.Btn11,
                         Btn12 = c.Btn12,
                         Btn13 = c.Btn13,
                         Btn14 = c.Btn14,
                         Task = c.Task
                     });
            return result;
        }

        [HttpGet("[action]")]
        public IEnumerable<QuestionType4DTO> GetQuestionsType4(int task, int count)
        {
            IEnumerable<QuestionType4> questions = db.QuestionsType4
                .Where(a => a.Task == task && !a.Deleted).ToList();
            DateTime date = DateTime.Now;
            if (date.Millisecond % 2 == 0)
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.QuestionLink).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.QuestionLink).Take(count).ToList();
                }
            }
            else
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.RightBtn).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.RightBtn).Take(count).ToList();
                }
            }
            IEnumerable<QuestionType4DTO> result = questions
                .Select(c =>
                     new QuestionType4DTO
                     {
                         Id = c.Id,
                         QuestionLink = c.QuestionLink,
                         Btn1 = c.Btn1,
                         Btn2 = c.Btn2,
                         Btn3 = c.Btn3,
                         Task = c.Task
                     });
            return result;
        }

        [HttpGet("[action]")]
        public IEnumerable<QuestionType5> GetQuestionsType5(int task, int count)
        {
            IEnumerable<QuestionType5> questions = db.QuestionsType5
                .Where(a => a.Task == task && !a.Deleted).ToList();
            DateTime date = DateTime.Now;
            if (date.Millisecond % 2 == 0)
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.QuestionLink).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.QuestionLink).Take(count).ToList();
                }
            }
            else
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.Id).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.Id).Take(count).ToList();
                }
            }
            return questions;
        }

        [HttpGet("[action]")]
        public IEnumerable<QuestionType6> GetQuestionsType6(int task, int count)
        {
            IEnumerable<QuestionType6> questions = db.QuestionsType6
            .Where(a => a.Task == task && !a.Deleted ).ToList();
            DateTime date = DateTime.Now;
            if (date.Millisecond % 2 == 0)
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.QuestionLink).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.QuestionLink).Take(count).ToList();
                }
            }
            else
            {
                if (date.Second % 2 == 0)
                {
                    questions = questions.OrderBy(a => a.Description1).Take(count).ToList();
                }
                else
                {
                    questions = questions.OrderByDescending(a => a.Description1).Take(count).ToList();
                }
            }
            
            return questions;
        }
    }
}
