using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserResults1DTO
    {
        public int? Number { get; set; }
        [MaxLength(5)]
        public string OfficialNumber { get; set; }
        [MaxLength(1000)]
        public string Title { get; set; }
        public int? Mistakes1 { get; set; }
        public DateTime StartTime1 { get; set; }
        public DateTime EndTime1 { get; set; }
        public int? Mistakes2 { get; set; }
        public DateTime StartTime2 { get; set; }
        public DateTime EndTime2 { get; set; }
    }
}
