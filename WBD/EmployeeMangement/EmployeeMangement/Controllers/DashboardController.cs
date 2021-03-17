using EmployeeMangement.Models.Product;
using EmployeeMangement.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IProductService productService;

        public DashboardController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/Dashboard/Gets")]
        public IActionResult Gets()
        {
            return Ok(productService.Gets());
        }

        [HttpPost]
        [Route("/Dashboard/Save")]
        public IActionResult Save([FromBody] SaveRequest request)
        {
            return Ok(productService.Save(request));
        }
    }
}
