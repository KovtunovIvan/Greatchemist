﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class QuestionType2DTO
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
        public int Task { get; set; }

    }
}
