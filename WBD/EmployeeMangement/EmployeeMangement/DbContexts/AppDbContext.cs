using EmployeeMangement.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.DbContexts
{
    public class AppDbContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<MemberFood> MemberFoods { get; set; }
        public DbSet<Product> Products { get; set; }

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
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Đá phong thuỷ tự nhiên",
                    Description = "Số 1 cao 40cm rộng 20cm dày 20cm màu xanh lá cây đậm",
                    Price = 1000000
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Đèn đá muối hình tròn",
                    Description = "Trang trí trong nhà Chất liệu : • Đá muối",
                    Price = 1500000
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Tranh sơn mài",
                    Description = "Tranh sơn mài loại nhỏ 15x 15 giá 50.000",
                    Price = 50000
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Tranh sơn dầu - Ngựa",
                    Description = "Nguyên liệu thể hiện :    Sơn dầu",
                    Price = 450000
                });
        }
    }
}
