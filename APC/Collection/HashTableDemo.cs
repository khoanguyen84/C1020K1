using System;
using System.Collections;

namespace Collection
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hb = new Hashtable();
            hb.Add(1, new Student(){ StudentId = 1, Fullname = "Khoa Nguyen"});
            hb.Add(2, new Student(){ StudentId = 2, Fullname = "Phuc Le"});
            hb.Add(3, new Student(){ StudentId = 3, Fullname = "Minh Ton"});

            // foreach(DictionaryEntry item in hb){
            //     Console.WriteLine(((Student)item.Value).PrintInfo());
            // }

            foreach(var key in hb.Keys){
                Console.WriteLine(((Student)hb[key]).PrintInfo());
            }

            foreach(Student item in hb.Values){
                Console.WriteLine(item.PrintInfo());
            }
        }
    }
}
