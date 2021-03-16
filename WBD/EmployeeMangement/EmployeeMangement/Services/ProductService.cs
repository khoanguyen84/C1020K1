using EmployeeMangement.DbContexts;
using EmployeeMangement.Entities;
using EmployeeMangement.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;

        public ProductService(AppDbContext context)
        {
            this.context = context;
        }

        public Product Get(int productId)
        {
            return context.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> Gets()
        {
            return context.Products.ToList();
        }
    }
}
