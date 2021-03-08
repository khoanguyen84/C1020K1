using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Models.Employee
{
    public class PaginationEmployee
    {
        public List<ViewEmployee> Employees { get; set; }
        public Pagination Pagination { get; set; }
    }
}
