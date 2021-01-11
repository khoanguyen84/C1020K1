using System;
namespace ProductManagement
{
    class Shop
    {
        public Product[] ProductList = new Product[0];

        public void AddProduct(string name, string desc, double price){
            Product product = new Product(name, desc, price);
            Array.Resize(ref ProductList, ProductList.Length + 1);
            ProductList[ProductList.Length-1] = product;
        }

        public bool IsExistProduct(string name){
            foreach(var product in ProductList){
                if(product.Name == name){
                    return true;
                }
            }
            return false;
        }
    }
}