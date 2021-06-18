using Shopping.BAL.Interface;
using Shopping.DAL.Interface;
using Shopping.Domain.Requests;
using Shopping.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.BAL.Implement
{
    public class CategoryService : ICatetoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<CreateCategoryRes> CreateCategory(CreateCategoryReq request)
        {
            try
            {
                if((await categoryRepository.GetCategoryByName(request.CategoryName)) != null)
                {
                    return new CreateCategoryRes()
                    {
                        CategoryId = 0,
                        Message = "Category is existed"
                    };
                }
                var result = await categoryRepository.CreateCategory(request);
                return new CreateCategoryRes()
                {
                    CategoryId = result,
                    Message = "Category has been created success"
                };
            }
            catch (Exception)
            {
                return new CreateCategoryRes()
                {
                    CategoryId = 0,
                    Message = "Something went wrong, please contact administrator."
                };
            }
        }

        public async Task<CreateCategoryRes> CreateCategory2(CreateCategoryReq request)
        {
            return await categoryRepository.CreateCategory2(request);
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            var result = await categoryRepository.GetCategoryById(categoryId);
            return result != null ? result : new Category();
        }

        public async Task<IEnumerable<Category>> Gets()
        {
            return await categoryRepository.Gets();
        }
    }
}
