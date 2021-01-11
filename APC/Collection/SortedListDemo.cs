using System;
using System.Collections;

namespace Collection
{
    class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList sd = new SortedList();
            sd.Add(5, "Khoa 5");
            sd.Add(1, "Khoa 1");
            sd.Add(3, "Khoa 3");
            sd.Add(2, "Khoa 2");
            sd.Add(4, "Khoa 4");

            foreach(var item in sd.Values){
                Console.WriteLine(item);
            }
        }
    }
}
