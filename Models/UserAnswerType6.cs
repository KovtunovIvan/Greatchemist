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
        [MaxLength(100)]
        public string UserAnswer1 { get; set; }
        [MaxLength(100)]
        public string UserAnswer2 { get; set; }
        [MaxLength(100)]
        public string UserAnswer3 { get; set; }
        public int Parallel { get; set; }

    }
}
