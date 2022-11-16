using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        [MaxLength(320)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public int GroupId { get; set; }
        public bool IsTeacher { get; set; }
        public bool IsManager { get; set; }
        public bool Deleted { get; set; }

    }
}
