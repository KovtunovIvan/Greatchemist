﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    //5
    public class QuestionType2
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
        public int RightBtn { get; set; }
        public int Task { get; set; }
        public bool Deleted { get; set; }

    }
}
