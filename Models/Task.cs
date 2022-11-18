using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int Number { get; set; }
        [MaxLength(5)]
        public string OfficialNumber { get; set; }
        [MaxLength(1000)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        //время на задание в миллисекундах, если ограничений нет, то 0
        public int Time { get; set; }
        public bool Deleted { get; set; }

    }
}
