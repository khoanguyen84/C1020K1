using EmployeeMangement.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public interface IDepartmentService
    {
        public List<DepartmentView> Gets();
    }
}
