using EmployeeMangement.DbContexts;
using EmployeeMangement.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly AppDbContext context;

        public DepartmentService(AppDbContext context)
        {
            this.context = context;
        }
        public List<DepartmentView> Gets()
        {
            var depts = (from d in context.Departments
                         select new DepartmentView()
                         {
                             DepartmentId = d.DepartmentId,
                             DepartmentName = d.DepartmentName
                         }).ToList();
            return depts;
        }
    }
}
