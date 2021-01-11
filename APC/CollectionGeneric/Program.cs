using System;
using System.Collections.Generic;

namespace CollectionGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
               LinkedList<string> ll = new LinkedList<string>();
               LinkedListNode<string> first = new LinkedListNode<string>("Khoa");
               ll.AddFirst(first);


               LinkedList<Product> llP = new LinkedList<Product>();
               LinkedListNode<Product> p1 = new LinkedListNode<Product>(new Product(1, "AFd"));
               llP.AddFirst(p1);
        }
    }

    class Product{
        public int Id { get; set; }
        public string Name { get; set; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
