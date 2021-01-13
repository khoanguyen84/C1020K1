using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Services
{
    public class OrderService : BaseService
    {
        private readonly TableService tableService;

        public OrderService()
        {
            tableService = new TableService();
        }

        public void NewOrder(int tableId)
        {
            Table table = tableService.FindTable(tableId);

        }
    }
}
