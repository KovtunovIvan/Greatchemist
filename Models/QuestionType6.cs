using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    //16(16.1)
    //17(16.2)
    //18(16.3)
    //19(16.4)
    //20(16.5)
    //21(16.6)
    //22(16.7)
    //23(16.8)
    //24(16.9)
    //25(16.10)
    //26(16.11)
    //27(16.12)
    //28(16.13)
    //29(16.14)
    //30(16.15)
    //31(16.16)
    public class QuestionType6
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string QuestionLink { get; set; }
        [MaxLength(100)]
        public string Description1 { get; set; }
        [MaxLength(100)]
        public string Description2 { get; set; }
        [MaxLength(100)]
        public string Description3 { get; set; }
        [MaxLength(100)]
        public string Right1 { get; set; }
        [MaxLength(100)]
        public string Right2 { get; set; }
        [MaxLength(100)]
        public string Right3 { get; set; }
        public int Task { get; set; }
        public bool Deleted { get; set; }

    }
}
