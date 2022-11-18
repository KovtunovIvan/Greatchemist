using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswersType3withRightsExt
    {
        public int Id { get; set; }
        public int IterationId { get; set; }
        public int QuestionId { get; set; }
        public int UserAnswer { get; set; }
        public int Parallel { get; set; }
        public int RightBtn { get; set; }
        public int Number { get; set; }
        [MaxLength(5)]
        public string OfficialNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
