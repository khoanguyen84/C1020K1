﻿using EmployeeMangement.Entities;
using EmployeeMangement.Models;
using EmployeeMangement.Models.Employee;
using EmployeeMangement.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IDepartmentService departmentService;

        public EmployeeController(IEmployeeService employeeService,
                                    IWebHostEnvironment webHostEnvironment,
                                    IDepartmentService departmentService)
        {
            this.employeeService = employeeService;
            this.webHostEnvironment = webHostEnvironment;
            this.departmentService = departmentService;
        }
        public IActionResult Index(int? pageNumber, int? pageSize, string keyword)
        {
            var employees = employeeService.Gets(keyword).OrderByDescending(e => e.Id).ToList();
            var pagination = new Pagination(employees.Count, pageNumber, pageSize, keyword);
            var viewModel = new PaginationEmployee()
            {
                Employees = employees.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize).ToList(),
                Pagination = pagination
            };
            return View(viewModel);
        }

        //public IActionResult Index()
        //{
        //    return View(employeeService.Gets());
        //}

        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.Departments = departmentService.Gets();
            var model = new CreateEmployee();
            model.Departments = departmentService.Gets();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateEmployee model)
        {
            if (ModelState.IsValid)
            {
                //1. get root
                //2. create folder path
                //3. filename path
                //4. copy image to folder step 2
                var filename = "noavatar.jpg";
                if (model.Avatar != null)
                {
                    var folderPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    filename = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(folderPath, filename);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                }
                var employee = new ViewEmployee()
                {
                    Age = model.Age,
                    AvatarPath = filename,
                    Code = model.Code,
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    DepartmentId = model.DepartmentId
                };
                if (employeeService.Create(employee))
                    return RedirectToAction("Index");
            }
            //ViewBag.Departments = departmentService.Gets();
            model.Departments = departmentService.Gets();
            return View(model);
        }

        public IActionResult Profile(int id)
        {
            var employee = employeeService.Get(id);
            employee.DepartmentName = departmentService.Gets().Single(d => d.DepartmentId == employee.DepartmentId).DepartmentName;
            return View(employee);
        }

        [HttpGet]
        [Route("/Employee/Edit/{employeeId}")]
        public IActionResult Edit(int employeeId)
        {
            var employee = employeeService.Get(employeeId);
            var editEmp = new EditEmployee()
            {
                AvatarPath = employee.AvatarPath,
                Age = employee.Age,
                Code = employee.Code,
                Email = employee.Email,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                Id = employee.Id
            };
            return View(editEmp);
        }

        [HttpPost]
        public IActionResult Edit(EditEmployee model)
        {
            if (ModelState.IsValid)
            {
                var existingAvatar = model.AvatarPath;
                if(model.Avatar != null)
                {
                    //remove exist file
                    
                    existingAvatar = existingAvatar.Split("/").Last();
                    if(string.Compare(existingAvatar, "noavatar.jpg") != 0)
                    {
                        System.IO.File.Delete(Path.Combine(webHostEnvironment.WebRootPath, "images", existingAvatar));
                    }
                    //upload new file
                    var folderPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    var filename = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(folderPath, filename);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                    existingAvatar = filename;
                }
                var employee = new ViewEmployee()
                {
                    Age = model.Age,
                    AvatarPath = existingAvatar,
                    Code = model.Code,
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Id = model.Id
                };
                if (employeeService.Edit(employee))
                    return RedirectToAction("Profile", "Employee", new { id = model.Id});
            }
            return View(model);
        }

        [HttpGet("/Employee/Delete/{employeeId}")]
        public IActionResult Delete(int employeeId)
        {
            var employee = employeeService.Get(employeeId);
            return View(employee);
        }

        [HttpGet("/Employee/ConfirmDelete/{employeeId}")]
        public IActionResult ConfirmDelete(int employeeId)
        {
            var delEmployee = employeeService.Get(employeeId);
            if(delEmployee != null)
            {
                var filename = delEmployee.AvatarPath.Split("/").Last();
                if (string.Compare(filename, "noavatar.jpg") != 0)
                {
                    System.IO.File.Delete(Path.Combine(webHostEnvironment.WebRootPath, "images", filename));
                }
                employeeService.Remove(delEmployee);
                return RedirectToAction("Index");
            }
            var employee = employeeService.Get(employeeId);
            ViewBag.Error = "Something went wrong, please contact administator";
            return View("~/Views/Employee/Delete.cshtml", employee);
        }
    }
}
