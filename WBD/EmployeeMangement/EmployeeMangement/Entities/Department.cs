using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(200)]
        public string DepartmentName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
