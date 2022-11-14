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
        [MaxLength(1000)]
        public string Description { get; set; }
        public bool Deleted { get; set; }

    }
}
