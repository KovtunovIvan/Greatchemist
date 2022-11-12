using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserAnswersType1withRights
    {
        public int Id { get; set; }
        public int IterationId { get; set; }
        public int QuestionId { get; set; }
        public int UserAnswer { get; set; }
        public int Parallel { get; set; }
        public int RightBtn { get; set; }
        public int Task { get; set; }

    }
}
