using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Services
{
    public class ShopService
    {
        public OrderService orderService;
        public TableService tableService;
        public PaymentService paymentService;
        public ShopService()
        {
            tableService = new TableService();
            orderService = new OrderService();
            paymentService = new PaymentService();
        }

        public void NewOrder(int tableId, List<OrderDetail> orderDetails)
        {
            orderService.NewOrder(tableId, orderDetails);
        }

        public void UpdateOrder(int tableId, List<OrderDetail> orderDetails)
        {
            orderService.UpdateOrder(tableId, orderDetails);
        }

        public void Pay(int tableId)
        {
            paymentService.Pay(tableId);
        }

        public void DisplayTables()
        {
            tableService.Display();
        }
    }
}
