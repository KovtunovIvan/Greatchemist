using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class Iteration
    {
        public int Id { get; set; }
        [MaxLength(320)]
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public bool Deleted { get; set; }

    }
}
