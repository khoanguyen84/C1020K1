using System;
using System.Collections.Generic;

namespace NUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ll = new LinkedList<string>();

            LinkedListNode<string> lln = new LinkedListNode<string>("Khoa");
            ll.AddFirst(lln);

            LinkedList<Student> llS = new LinkedList<Student>();
            LinkedListNode<Student> lln1 = new LinkedListNode<Student>(new Student(1, "Khoa"));

            llS.AddFirst(lln1);

            foreach (Student std in llS)
            {
                std.PrintInfo();
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }
    }
}
