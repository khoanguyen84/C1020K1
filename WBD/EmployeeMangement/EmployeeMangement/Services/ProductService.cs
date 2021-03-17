using EmployeeMangement.DbContexts;
using EmployeeMangement.Entities;
using EmployeeMangement.Models.Department;
using EmployeeMangement.Models.Product;
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

        public SaveResponse Save(SaveRequest request)
        {
            var result = new SaveResponse()
            {
                Success = false,
                Message = "Something went wrong, please contact administrator"
            };
            try
            {
                //add new
                if (request.ProductId == 0)
                {
                    var product = new Product()
                    {
                        ProductId = request.ProductId,
                        Description = request.Description,
                        Price = request.Price,
                        ProductName = request.ProductName
                    };
                    context.Add(product);
                    result.Success = context.SaveChanges() > 0;
                    result.Message = "Product has been created successfully";
                }
            }
            catch(Exception ex)
            {

            }
            return result;
        }
    }
}
