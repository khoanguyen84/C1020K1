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
                    Lastname = request.Lastname
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
                        Lastname = e.Lastname
                    }).FirstOrDefault();
        }

        public List<ViewEmployee> Gets()
        {
            var employees = context.Employees.ToList();
            var viewEmployees = (from e in employees
                                 select new ViewEmployee() { 
                                     Age = e.Age,
                                     AvatarPath = e.AvatarPath,
                                     Code = e.Code,
                                     Email = e.Email,
                                     Firstname = e.Firstname,
                                     Id = e.EmployeeId,
                                     Lastname = e.Lastname
                                 });
            return viewEmployees.ToList();
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
