using Shopping.Domain.Requests;
using Shopping.Domain.Responses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.BAL.Interface
{
    public interface ICatetoryService
    {
        public Task<IEnumerable<Category>> Gets();
        public Task<Category> GetCategoryById(int categoryId);
        public Task<CreateCategoryRes> CreateCategory(CreateCategoryReq request);
    }
}

