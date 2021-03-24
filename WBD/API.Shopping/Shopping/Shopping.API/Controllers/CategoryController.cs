using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.BAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICatetoryService categoryService;

        public CategoryController(ICatetoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        [Route("api/category/gets")]
        public async Task<IActionResult> Gets()
        {
            return Ok(await categoryService.Gets());
        }
    }
}
