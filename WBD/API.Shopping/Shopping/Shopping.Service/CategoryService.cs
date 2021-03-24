using Shopping.BAL.Interface;
using Shopping.DAL.Interface;
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
        public async Task<IEnumerable<Category>> Gets()
        {
            return await categoryRepository.Gets();
        }
    }
}
