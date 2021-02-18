using System;

namespace Bai1
{
    public class Employee
    {
        public int X = 2;
        public void main(string[] args) {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            X = 5;
            Console.WriteLine("x=%d, y=%d, z=%d", o1.X, o2.X, X);
        }

    }
}