using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    //1,2,3,4,7,9,10,11
    public class QuestionType1
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string QuestionLink { get; set; }
        [MaxLength(100)]
        public string Btn1 { get; set; }
        [MaxLength(100)]
        public string Btn2 { get; set; }
        public int RightBtn { get; set; }
        public int Task { get; set; }
        public bool Deleted { get; set; }

    }
}
