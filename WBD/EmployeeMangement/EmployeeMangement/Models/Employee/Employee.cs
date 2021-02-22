using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Models.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname => $"{Firstname} {Lastname}";
        public string AvatarPath { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
