using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    //6
    public class QuestionType3
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string QuestionLink { get; set; }
        [MaxLength(100)]
        public string Btn1 { get; set; }
        [MaxLength(100)]
        public string Btn2 { get; set; }
        [MaxLength(100)]
        public string Btn3 { get; set; }
        [MaxLength(100)]
        public string Btn4 { get; set; }
        [MaxLength(100)]
        public string Btn5 { get; set; }
        [MaxLength(100)]
        public string Btn6 { get; set; }
        [MaxLength(100)]
        public string Btn7 { get; set; }
        [MaxLength(100)]
        public string Btn8 { get; set; }
        [MaxLength(100)]
        public string Btn9 { get; set; }
        [MaxLength(100)]
        public string Btn10 { get; set; }
        [MaxLength(100)]
        public string Btn11 { get; set; }
        [MaxLength(100)]
        public string Btn12 { get; set; }
        [MaxLength(100)]
        public string Btn13 { get; set; }
        [MaxLength(100)]
        public string Btn14 { get; set; }
        public int RightBtn { get; set; }
        public int Task { get; set; }
        public bool Deleted { get; set; }

    }
}
