using CoffeeManagement.Models;
using CoffeeManagement.Ultilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoffeeManagement.Services
{
    public class OrderService : BaseService
    {
        private readonly TableService tableService;
        private readonly string orderFile = $"Order_{DateTime.Now.ToString("ddMMyyy")}.json";
        private readonly string fullPath;
        private List<Order> Orders;

        public OrderService()
        {
            tableService = new TableService();
            fullPath = Path.Combine(path, orderFile);
            if (File.Exists(fullPath))
            {
                Orders = Helper.ReadFile<List<Order>>(fullPath);
            }
            else
            {
                Orders = new List<Order>();
            }
        }

        public void NewOrder(int tableId, List<OrderDetail> orderDetails)
        {
            Table table = tableService.FindTable(tableId);
            if(table.tableId != 0)
            {
                Order order = new Order()
                {
                    tableId = tableId,
                    startTime = DateTime.Now,
                    endTime = null,
                    ispaid = false
                };

                order.OrderDetails = orderDetails;

                Orders.Add(order);

                Helper.WriteFile<List<Order>>(fullPath, Orders);
            }
        }

        public void UpdateOrder(int tableId, List<OrderDetail> newOrderDetails)
        {
            Order orderNeedUpdate = new Order();
            bool isExist = false;
            //find order needed update
            foreach(Order order in Orders)
            {
                if(order.tableId == tableId && !order.ispaid)
                {
                    orderNeedUpdate = order;
                    break;
                }
            }
            //update order details
            foreach(OrderDetail nod in newOrderDetails)
            {
                isExist = false;
                foreach(OrderDetail ood in orderNeedUpdate.OrderDetails)
                {
                    if(ood.productName == nod.productName)
                    {
                        ood.quantity += nod.quantity;
                        isExist = true;
                    }
                }
                if (!isExist)
                {
                    orderNeedUpdate.OrderDetails.Add(nod);
                }
            }
            Helper.WriteFile<List<Order>>(fullPath, Orders);
        }

        public Order GetOrderByTableId(int tableId)
        {
            foreach (Order order in Orders)
            {
                if (order.tableId == tableId && !order.ispaid)
                {
                    return order;
                }
            }
            return new Order();
        }

        public void UpdateOrderAfterPaid(int tableId)
        {
            Order orderNeedUpdate = GetOrderByTableId(tableId);
            orderNeedUpdate.endTime = DateTime.Now;
            orderNeedUpdate.ispaid = true;

            Helper.WriteFile<List<Order>>(fullPath, Orders);
        }
    }
}
