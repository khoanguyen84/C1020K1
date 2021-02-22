using EmployeeMangement.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MockEmployeeService employeeService;

        public EmployeeController()
        {
            this.employeeService = new MockEmployeeService();
        }
        public IActionResult Index()
        {
            return View(employeeService.Gets());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
