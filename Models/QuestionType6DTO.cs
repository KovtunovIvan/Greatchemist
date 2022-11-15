using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class QuestionType6DTO
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string QuestionLink { get; set; }
        [MaxLength(100)]
        public string Description1 { get; set; }
        [MaxLength(100)]
        public string Description2 { get; set; }
        public int Task { get; set; }
    }
}
