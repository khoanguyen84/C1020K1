using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Domain.Responses
{
    public class CreateCategoryRes
    {
        public int CategoryId { get; set; }
        public string Message { get; set; }
        public bool Success => CategoryId > 0;
    }
}
