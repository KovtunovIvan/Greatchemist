using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswerType6DTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IEnumerable<UserAnswerType6> Answers { get; set; }
        public int Task { get; set; }

    }
}
