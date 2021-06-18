using Shopping.Domain.Requests;
using Shopping.Domain.Responses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.DAL.Interface
{
    public interface ICategoryRepository
    {
        public Task<IEnumerable<Category>> Gets();
        public Task<Category> GetCategoryById(int categoryId);
        public Task<int> CreateCategory(CreateCategoryReq request);
        public Task<Category> GetCategoryByName(string categoryName);

        public Task<CreateCategoryRes> CreateCategory2(CreateCategoryReq request);
    }
}
