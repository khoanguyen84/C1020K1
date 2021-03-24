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
    }
}

