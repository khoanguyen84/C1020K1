using System;
namespace Bai1
{
    class ArrayDemo
    {
        public static void Main()
        {
        //     int[] arr = new int[0];
        //     int i = 0;
        //     int value = 0;
        //     do{
        //         Console.Write($"A[{i}] = ");
        //         Array.Resize(ref arr, arr.Length + 1);
        //         value = int.Parse(Console.ReadLine());
        //         arr[arr.Length-1] = value;
        //         i++;
        //     }
        //     while(value != 0);

            Number number = new Number(10, 15, 20);
            number.Number1 = 5;
            number.Number2 = 7;
            var pi =  Number.Pi;
            // number.SetNumber3(10);
            // number.Number4 = 15;
            Console.WriteLine($"n3: {number.GetNumber3()}");
            Console.WriteLine($"n4: {number.Number4}");
            Console.WriteLine($"n5: {number.Number5}");
            Console.WriteLine($"n1: {number.Number1}, n2: {number.Number2}");
            number.Swap();
            Number.Sologen();
            Console.WriteLine($"n1: {number.Number1}, n2: {number.Number2}");

            Parent parent = new Parent();
            Parent.Child child = new Parent.Child();
        }
    }
}