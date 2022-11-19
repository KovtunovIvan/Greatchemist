using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class UserResultsDTO
    {
        public List<UserResults1DTO> R1 { get; set; }
        public List<UserResults2DTO> R2 { get; set; }
        public List<UserResults3DTO> R3 { get; set; }
    }
}
