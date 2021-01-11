using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> myList = new MyList<int>();
            //myList.Add(5);
            //var temp = myList[-1];
            //for (int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine(myList[i]);
            //}

            MyList<int> lt = new MyList<int>();
            Console.WriteLine($"{lt.Capacity}, {lt.Count}");
            lt.Add(6);
            Console.WriteLine(lt.Capacity);
            lt.AddRange(new int[] { 6, 6, 6, 6, 6, 6,6,6,6 });
            Console.WriteLine(lt.Capacity);
            lt.Add(6);
            lt.Add(6);
            lt.Add(6);
            lt.Add(6);
            Console.WriteLine(lt.Capacity);
            lt.Add(6);
            Console.WriteLine(lt.Capacity);
            lt.Add(6);
            lt.Add(6);
            lt.Add(6);
            lt.Add(6);
            Console.WriteLine(lt.Capacity);


            MyList<Student> myList = new MyList<Student>();
            MyList<List<Student>> list = new MyList<List<Student>>();
        }
    }
}
