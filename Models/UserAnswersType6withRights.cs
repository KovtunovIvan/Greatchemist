using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswersType6withRights
    {
        public int Id { get; set; }
        public int IterationId { get; set; }
        public int QuestionId { get; set; }
        public int Parallel { get; set; }
        public float UserAnswer1 { get; set; }
        public float Right1 { get; set; }
        public float UserAnswer2 { get; set; }
        public float Right2 { get; set; }
        public int Task { get; set; }

    }
}
