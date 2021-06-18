using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.BAL.Interface;
using Shopping.Domain.Requests;
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
        /// <summary>
        /// Get categories in actived
        /// </summary>
        /// <returns>list of categories</returns>
        [HttpGet]
        [Route("api/category/gets")]
        public async Task<IActionResult> Gets()
        {
            return Ok(await categoryService.Gets());
        }

        /// <summary>
        /// Get category by category Id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/category/get/{categoryId}")]
        public async Task<IActionResult> GetCategoryById(int categoryId)
        {
            return Ok(await categoryService.GetCategoryById(categoryId));
        }

        /// <summary>
        /// Create category
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/category/create")]
        public async Task<IActionResult> Create(CreateCategoryReq req)
        {
            return Ok(await categoryService.CreateCategory2(req));
        }
    }
}
