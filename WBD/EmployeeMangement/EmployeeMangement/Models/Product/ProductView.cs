using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Models.Product
{
    public class ProductView
    {
        public List<Entities.Product> Products { get; set; }
        public Pagination Pagination { get; set; }
    }
}
