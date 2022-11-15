using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswerType6
    {
        public int Id { get; set; }
        public int IterationId { get; set; }
        public int QuestionId { get; set; }
        public float UserAnswer1 { get; set; }
        public float UserAnswer2 { get; set; }
        public int Parallel { get; set; }

    }
}
