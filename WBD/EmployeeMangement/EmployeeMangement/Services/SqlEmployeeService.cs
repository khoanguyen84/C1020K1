using EmployeeMangement.DbContexts;
using EmployeeMangement.Entities;
using EmployeeMangement.Models.Employee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public class SqlEmployeeService : IEmployeeService
    {
        private readonly AppDbContext context;

        public SqlEmployeeService(AppDbContext context)
        {
            this.context = context;
        }
        public bool Create(ViewEmployee request)
        {
            try
            {
                var employee = new Employee()
                {
                    EmployeeId = request.Id,
                    Age = request.Age,
                    AvatarPath = request.AvatarPath,
                    Code = request.Code,
                    Email = request.Email,
                    Firstname = request.Firstname,
                    Lastname = request.Lastname,
                    DepartmentId = request.DepartmentId
                };
                context.Add(employee);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(ViewEmployee request)
        {
            try
            {
                var editEmployee = context.Employees.Find(request.Id);
                editEmployee.AvatarPath = request.AvatarPath;
                editEmployee.Age = request.Age;
                editEmployee.Code = request.Code;
                editEmployee.Email = request.Email;
                editEmployee.Firstname = request.Firstname;
                editEmployee.Lastname = request.Lastname;
                context.Attach(editEmployee);
                context.Entry<Employee>(editEmployee).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public ViewEmployee Get(int id)
        {
            //var depts = context.Departments.Include(d => d.Employees).ToList();
            //var depts2 = (from d in context.Departments
            //              select new Department() {
            //                  Employees = (from e in context.Employees
            //                               where e.DepartmentId == d.DepartmentId && e.Age >= 18
            //                               select e).ToList() });
            //var employee = context.Employees.Include(e => e.Department).Single(e => e.EmployeeId == 1);
            //return new ViewEmployee()
            //{
            //    Age = employee.Age,
            //    AvatarPath = employee.AvatarPath,
            //    Code = employee.Code,
            //    Email = employee.Email,
            //    Firstname = employee.Firstname,
            //    Id = employee.EmployeeId,
            //    Lastname = employee.Lastname,
            //    DepartmentId = employee.Department.DepartmentId,
            //    DepartmentName = employee.Department.DepartmentName
            //};
            //return (from e in context.Employees
            //        join d in context.Departments on e.DepartmentId equals d.DepartmentId
            //        where e.EmployeeId == id
            //        select new EmployeeProfile()
            //        {
            //            Age = e.Age,
            //            AvatarPath = e.AvatarPath,
            //            Code = e.Code,
            //            Email = e.Email,
            //            Firstname = e.Firstname,
            //            Id = e.EmployeeId,
            //            Lastname = e.Lastname,
            //            DepartmentName = d.DepartmentName
            //        }).FirstOrDefault();
            return (from e in context.Employees
                    where e.EmployeeId == id
                    select new ViewEmployee()
                    {
                        Age = e.Age,
                        AvatarPath = e.AvatarPath,
                        Code = e.Code,
                        Email = e.Email,
                        Firstname = e.Firstname,
                        Id = e.EmployeeId,
                        Lastname = e.Lastname,
                        DepartmentId = e.DepartmentId
                    }).FirstOrDefault();
        }

        public List<ViewEmployee> Gets(string keyword)
        {
            var employees = context.Employees.ToList();
            var viewEmployees = new List<ViewEmployee>();
            if (!string.IsNullOrEmpty(keyword))
            {
                viewEmployees = (from e in employees
                                 where e.Firstname.ToLower().Contains(keyword.ToLower()) || e.Lastname.ToLower().Contains(keyword.ToLower())
                                 select new ViewEmployee()
                                 {
                                     Age = e.Age,
                                     AvatarPath = e.AvatarPath,
                                     Code = e.Code,
                                     Email = e.Email,
                                     Firstname = e.Firstname,
                                     Id = e.EmployeeId,
                                     Lastname = e.Lastname
                                 }).ToList();
            }
            else
            {
                viewEmployees = (from e in employees
                                 select new ViewEmployee()
                                 {
                                     Age = e.Age,
                                     AvatarPath = e.AvatarPath,
                                     Code = e.Code,
                                     Email = e.Email,
                                     Firstname = e.Firstname,
                                     Id = e.EmployeeId,
                                     Lastname = e.Lastname
                                 }).ToList();
            }
            return viewEmployees;
        }

        public bool Remove(ViewEmployee request)
        {
            try
            {
                var delEmployee = context.Employees.Find(request.Id);
                context.Remove(delEmployee);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}
