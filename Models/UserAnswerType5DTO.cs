using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswerType5DTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Task { get; set; }
        public int IterationId { get; set; }
        public int Parallel { get; set; }

    }
}
