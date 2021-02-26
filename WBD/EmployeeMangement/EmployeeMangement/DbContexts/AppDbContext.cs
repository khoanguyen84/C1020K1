using EmployeeMangement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<MemberFood> MemberFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department()
                {
                    DepartmentId = 1,
                    DepartmentName = "IT",
                    Email = "it@codegym.vn",
                    PhoneNumber = "0935216417"
                },
                new Department()
                {
                    DepartmentId = 2,
                    DepartmentName = "HR",
                    Email = "hr@codegym.vn",
                    PhoneNumber = "0935216417"
                });
                
                
            modelBuilder.Entity<Employee>().HasData(
                new Employee() {
                    Age = 18,
                    AvatarPath = "avatar11.jpg",
                    Code = "CGH00001",
                    Firstname = "Khoa",
                    Lastname = "Nguyen",
                    Email = "khoa.nguyen@codegym.vn",
                    EmployeeId = 1,
                    DepartmentId = 1
                },
                new Employee() {
                    Age = 18,
                    AvatarPath = "avatar10.jpg",
                    Code = "CGH00002",
                    Firstname = "Hung",
                    Lastname = "Tran",
                    Email = "hung.tran@codegym.vn",
                    EmployeeId = 2,
                    DepartmentId = 1
                },
                new Employee()
                {
                    Age = 18,
                    AvatarPath = "avatar14.jpg",
                    Code = "CGH00003",
                    Firstname = "Huy",
                    Lastname = "Phan",
                    Email = "huy.phan@codegym.vn",
                    EmployeeId = 3,
                    DepartmentId = 2
                });
        }
    }
}
