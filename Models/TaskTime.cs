using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class TaskTime
    {
        public int Id { get; set; }
        public int IterationId { get; set; }
        public int TaskId { get; set; }
        public int Parallel { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
