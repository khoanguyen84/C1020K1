using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Entities
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public int Status { get; set; }
        public ICollection<MemberFood> MemberFoods { get; set; }
    }
}
