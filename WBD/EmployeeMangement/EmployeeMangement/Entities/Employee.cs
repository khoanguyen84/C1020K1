using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(10)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string AvatarPath { get; set; }
        [Required]
        [MaxLength(8)]
        public string Code { get; set; }
    }
}
