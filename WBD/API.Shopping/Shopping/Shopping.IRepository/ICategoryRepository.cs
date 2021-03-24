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
    }
}
