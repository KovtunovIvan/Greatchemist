using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswersType6withRights
    {
        public int Id { get; set; }
        public int IterationId { get; set; }
        public int QuestionId { get; set; }
        public int Parallel { get; set; }
        [MaxLength(100)]
        public string UserAnswer1 { get; set; }
        [MaxLength(100)]
        public string Right1 { get; set; }
        [MaxLength(100)]
        public string UserAnswer2 { get; set; }
        [MaxLength(100)]
        public string Right2 { get; set; }
        [MaxLength(100)]
        public string UserAnswer3 { get; set; }
        [MaxLength(100)]
        public string Right3 { get; set; }
        public int Task { get; set; }

    }
}
