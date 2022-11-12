using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(320)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public int GroupId { get; set; }
        // ведущая рука (0 - П, 1 - Л)
        public bool MainHand { get; set; }
        public DateTime BirthDay { get; set; }
        [MaxLength(500)]
        public string AdditionalInf { get; set; }
        public bool Deleted { get; set; }

    }
}
