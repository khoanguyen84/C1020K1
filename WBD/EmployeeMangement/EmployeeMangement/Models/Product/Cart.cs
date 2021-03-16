using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Models.Product
{
    public class Cart
    {
        public int Quantity { get; set; }
        public Entities.Product Product { get; set; }
    }
}
