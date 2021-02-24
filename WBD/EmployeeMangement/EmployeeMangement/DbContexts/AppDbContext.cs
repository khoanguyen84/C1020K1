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
        DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee() {
                    Age = 18,
                    AvatarPath = "avatar11.jpg",
                    Code = "CGH00001",
                    Firstname = "Khoa",
                    Lastname = "Nguyen",
                    Email = "khoa.nguyen@codegym.vn",
                    EmployeeId = 1
                },
                new Employee() {
                    Age = 18,
                    AvatarPath = "avatar10.jpg",
                    Code = "CGH00002",
                    Firstname = "Hung",
                    Lastname = "Tran",
                    Email = "hung.tran@codegym.vn",
                    EmployeeId = 2
                },
                new Employee()
                {
                    Age = 18,
                    AvatarPath = "avatar14.jpg",
                    Code = "CGH00003",
                    Firstname = "Huy",
                    Lastname = "Phan",
                    Email = "huy.phan@codegym.vn",
                    EmployeeId = 3
                });
        }
    }
}
