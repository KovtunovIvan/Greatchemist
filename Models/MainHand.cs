using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class MainHand
    {
        public int Id { get; set; }
        [MaxLength(6)]
        public string Title { get; set; }
        public bool Deleted { get; set; }

    }
}
