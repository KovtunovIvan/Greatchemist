using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswerType5
    {
        public int Id { get; set; }
        public int IterationId { get; set; }
        public int QuestionId { get; set; }
        public string UserAnswer { get; set; }
        public int Parallel { get; set; }

    }
}
