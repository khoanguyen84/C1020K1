using System;

namespace ProductManagement
{
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            CreateProduct();
            ShowProducts();
        }

        private static void ShowProducts()
        {
            Console.WriteLine($"Name\t\tDescripttion\t\tPrice\t\tRate");
            foreach (var product in shop.ProductList)
            {
                Console.WriteLine(product.ViewInfo());
            }
        }

        private static void CreateProduct()
        {
            Console.Write("Input product name: ");
            var name = Console.ReadLine();
            if(shop.IsExistProduct(name)){
                Console.Write($"Product name {name} is exists");    
            }
            else{
                Console.Write("Input description: ");
                var description = Console.ReadLine();
                Console.Write("Input price: ");
                double price = double.Parse(Console.ReadLine());
                shop.AddProduct(name: name, price: price, desc: description);
            }
        }
    }
}
