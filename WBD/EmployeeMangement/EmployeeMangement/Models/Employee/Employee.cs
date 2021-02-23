using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Models.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is required")]
        [Display(Name = "Employee Code")]
        [StringLength(maximumLength:8, MinimumLength =8, ErrorMessage = "Employee code must 8 characters")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Fristname is required")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }
        public string Fullname => $"{Firstname} {Lastname}";
        public string AvatarPath { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(minimum:18, maximum:60, ErrorMessage ="Age must between 18 and 60")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }
    }
}
