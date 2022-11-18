using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswersType6withRightsExt
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
        public int Number { get; set; }
        [MaxLength(5)]
        public string OfficialNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
