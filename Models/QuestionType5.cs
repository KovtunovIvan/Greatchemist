using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    //12,13
    public class QuestionType5
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string QuestionLink { get; set; }
        public int Task { get; set; }
        public bool Deleted { get; set; }

    }
}
