using CoffeeManagement.Models;
using CoffeeManagement.Services;
using CoffeeManagement.Ultilities;
using System;
using System.Collections.Generic;

namespace CoffeeManagement
{
    class Program
    {
        public static ShopService shopService = new ShopService();
        static void Main(string[] args)
        {
            #region
            //List<OrderDetail> orderDetails = new List<OrderDetail>()
            //{
            //    new OrderDetail()
            //    {
            //        productName = "Black Coffee",
            //        price = 10000,
            //        quantity = -1
            //    },
            //    new OrderDetail()
            //    {
            //        productName = "Milk Coffee",
            //        price = 15000,
            //        quantity = 1
            //    },
            //    new OrderDetail()
            //    {
            //        productName = "Coca",
            //        price = 9000,
            //        quantity = 2
            //    }
            //};
            //shopService.UpdateOrder(1, orderDetails);
            #endregion
            //shopService.Pay(1);
            //List<OrderDetail> orderDetails = new List<OrderDetail>()
            //{
            //    new OrderDetail()
            //    {
            //        productName = "coffee milk",
            //        price = 12000,
            //        quantity = 1
            //    },
            //    new OrderDetail()
            //    {
            //        productName = "Coca",
            //        price = 10000,
            //        quantity = 2
            //    }
            //};
            //shopService.UpdateOrder(1, orderDetails);
            //shopService.DisplayTables();
            shopService.Pay(3);
        }
    }
}
