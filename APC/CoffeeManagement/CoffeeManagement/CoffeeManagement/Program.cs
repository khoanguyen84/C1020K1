using CoffeeManagement.Models;
using CoffeeManagement.Services;
using CoffeeManagement.Ultilities;
using System;

namespace CoffeeManagement
{
    class Program
    {
        public static TableService tableService = new TableService();
        static void Main(string[] args)
        {
            tableService.Update(1, (int)Common.TableStatus.InUsed);

            tableService.Display();
        }
    }
}
