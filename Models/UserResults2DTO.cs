﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserResults2DTO
    {
        public int? Number { get; set; }
        [MaxLength(5)]
        public string OfficialNumber { get; set; }
        [MaxLength(1000)]
        public string Title { get; set; }
        public string UserAnswer { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
