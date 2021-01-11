using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] numbers = new char[10] {'0','1','2','3','4','5','6','7','8','9'};
            string str = "sdfgsdf23453dgdf";
            var characters = str.ToCharArray();
            string result = "";
            bool flat = false;
            for(int i =0; i< characters.Length; i++){
                flat = false;
                for(int j=0; j<numbers.Length;j++){
                    if(characters[i] == numbers[j]){
                        flat = true;
                        break;
                    }
                }

                if(!flat){
                    result+=characters[i];
                }
            }
            // Console.Write(result);

            Animal animal = new Animal("CAT", 1.0);
            animal.PrintInfo();
            animal = new Animal("DOG",2.2);
            animal.PrintInfo();
            animal.Name = "TiGER";
            animal.PrintInfo();
            // ArrayList al = new ArrayList();
            // al.Add(1);
            // al.Add(100);
            // al.Add(3);

            // Student std = new Student();
            // std.StudentId = 1;
            // std.Fullname = "Khoa Nguyen";

            // Student std = new Student()
            // {
            //     StudentId = 1,
            //     Fullname = "Khoa Nguyen"
            // };

            // al.Add(std);

            // al.Add(new Student(){
            //     StudentId = 1,
            //     Fullname = "Khoa Nguyen"
            // });

            
            // foreach(var item in al){
            //     if(item.GetType().ToString() == "Collection.Student"){
            //         Console.WriteLine(((Student)item).PrintInfo());    
            //     }
            //     else
            //     {
            //         Console.WriteLine(item);    
            //     }
            // }
            // al.Remove("Khoa");
            // al.RemoveAt(1);
            // al.RemoveRange(0,2);

            // al.Sort(new ALCompare());
            // foreach(int item in al){
            //     Console.WriteLine(item);
            // }
        }
    }

    class ALCompare : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            return ((Student)x).StudentId - ((Student)y).StudentId;
        }
    }

    class Animal
    {
        public string Name { get; set; }  
        public double Age { get; set; }

        public Animal(string name, double age)
        {
            Name= name;
            Age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name},Age: {Age}");
        }
    }
}
