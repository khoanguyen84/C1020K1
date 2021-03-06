﻿using EmployeeMangement.Entities;
using EmployeeMangement.Models.Department;
using EmployeeMangement.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public interface IProductService
    {
        public List<Product> Gets();
        public Product Get(int productId);
        public SaveResponse Save(SaveRequest request);
    }
}
