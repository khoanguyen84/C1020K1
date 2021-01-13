using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Models
{
    public class Table
    {
        public int tableId { get; set; }
        public string tableCode { get; set; }
        public int status { get; set; }

        public override string ToString()
        {
            return $"{tableId}\t{tableCode}\t{status}";
        }
    }
}
