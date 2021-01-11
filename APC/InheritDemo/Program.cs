using System;

namespace InheritDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student student = new Student();
            // student.FirstName = "Khoa";
            // student.LastName = "Nguyen";
            // student.Email = "khoa.nguyen@codegym.vn";
            // Console.Write(student.PrintInfo());
            // Student std = new Student("Khoa", "Nguyen", "kn@cg.vn");
            // Console.Write(std.Sum(5,7));


            // Person p = new Person("Khoa", "Nguyen");
            // Console.Write(p.Sum(5,7));

            // object n1 = 10;
            // int n2 =  (int)n1 + 5;

            // Object obj = new Object();
            // Console.WriteLine(obj.ToString());
            // Human human = new Human();
            // Console.WriteLine(human.ToString());
            // Female female = new Female();
            // Console.WriteLine(female.ToString());

            // Human h1 = new Female();
            // Console.WriteLine(h1.ToString());

            Shape[] shapes = new Shape[4] { new Triangle(), new Circle(), new Triangle(), new Oval()};
            foreach(var shape in shapes){
                Console.WriteLine(shape.GetType());
            }

            Triangle[] triangles = new Triangle[2];
            Circle[] circles = new Circle[3];
        }
    }

    class Shape
    {

    }

    class Triangle : Shape
    {

    }

    class Circle : Shape
    {

    }

    class Oval : Circle
    {

    }
}
