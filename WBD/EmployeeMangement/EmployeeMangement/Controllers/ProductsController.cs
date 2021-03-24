using EmployeeMangement.Models.Product;
using EmployeeMangement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }


        [Route("api/products/Gets")]
        public IActionResult GetProducts()
        {
            return Ok(productService.Gets());
        }

        [HttpPost]
        [Route("api/products/save")]
        public IActionResult Save(SaveRequest request)
        {
            return Ok(productService.Save(request));
        }
}
}
