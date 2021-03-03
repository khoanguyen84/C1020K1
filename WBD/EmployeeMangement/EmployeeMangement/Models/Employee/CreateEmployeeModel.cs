using EmployeeMangement.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Models.Employee
{
    public class CreateEmployeeModel : ViewEmployee
    {
        public List<DepartmentView> Departments { get; set; }
    }
}
