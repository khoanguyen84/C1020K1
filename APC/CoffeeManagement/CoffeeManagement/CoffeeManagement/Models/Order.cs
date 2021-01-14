using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Models
{
    public class Order
    {
        public int tableId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime? endTime { get; set; }
        public decimal totalAmount => CalsTotalAmount();
        public bool ispaid { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        private decimal CalsTotalAmount()
        {
            decimal total = 0;
            foreach(OrderDetail od in OrderDetails)
            {
                total += od.amount;
            }
            return total;
        }
    }

    public class OrderDetail
    {
        public string productName { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal amount => quantity * price;
    }
}
