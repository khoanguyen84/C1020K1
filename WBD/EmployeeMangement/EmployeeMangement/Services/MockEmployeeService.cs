using EmployeeMangement.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public class MockEmployeeService : IEmployeeService
    {
        private List<Employee> employees;
        public MockEmployeeService()
        {
            employees = new List<Employee>()
            {
                new Employee()
                {
                    Age = 18,
                    AvatarPath = "~/images/avatar11.jpg",
                    Code = "CGH001",
                    Firstname = "Khoa",
                    Lastname = "Nguyen",
                    Id = 1
                },
                new Employee()
                {
                    Age = 18,
                    AvatarPath = "~/images/avatar10.jpg",
                    Code = "CGH002",
                    Firstname = "Hung",
                    Lastname = "Tran",
                    Id = 2
                },
                new Employee()
                {
                    Age = 18,
                    AvatarPath = "~/images/avatar14.jpg",
                    Code = "CGH003",
                    Firstname = "Huy",
                    Lastname = "Phan",
                    Id = 3
                }
            };
        }

        public bool Create(Employee request)
        {
            try
            {
                employees.Add(request);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Employee> Gets()
        {
            return employees;
        }


    }
}
