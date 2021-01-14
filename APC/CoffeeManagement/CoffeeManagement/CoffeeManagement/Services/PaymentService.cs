using CoffeeManagement.Models;
using CoffeeManagement.Ultilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoffeeManagement.Services
{
    public class PaymentService : BaseService
    {
        private readonly TableService tableService;
        private readonly OrderService orderService;
        private string formatBillFile = "Bill_{0}_{1}.json";
        private string fullPath;
        public PaymentService()
        {
            tableService = new TableService();
            orderService = new OrderService();
        }

        public void Pay(int tableId)
        {
            //generate bill file
            string billFile = string.Format(formatBillFile, tableId, DateTime.Now.ToString("ddMMyyyyhhmmss"));
            fullPath = Path.Combine(path, billFile);

            //get order needed to pay by tableid
            Order orderNeedPay = orderService.GetOrderByTableId(tableId);

            //update order paid
            orderService.UpdateOrderAfterPaid(tableId);

            //print bill
            Helper.WriteFile<Order>(fullPath, orderNeedPay);
        }
    }
}

