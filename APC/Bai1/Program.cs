using System;
using System.Reflection;
using System.Text;
using Bai1;
// using Help;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.InputEncoding = Encoding.UTF8;
            // Console.OutputEncoding = Encoding.UTF8;
            // Console.WriteLine("Hello World!");
            // Console.Write("C1020K1");
            // Console.WriteLine("CodGym Huế");
            // MyMath myMath = new MyMath();
            // Console.Write(myMath.Sum(5,7));
            // Console.WriteLine(Subtract(10,6));

            // object n = 10;
            // Console.WriteLine((int)n + 1);

            // dynamic str = "C1020K1";
            // str++;
            // byte i = 0;
            // for(;i<255;){
            //     // Console.WriteLine($"i = {i}");
            //     // Console.WriteLine("i = " + i);
            //     Console.WriteLine("i = {0}, {1}",i, 3);
            //     i++;
            // }
            // do{
            //     Console.WriteLine("i = {0}, {1}",i, 3);
            //     i++;
            // }
            // while(i<255);
            // Console.WriteLine($"{long.MaxValue}");
            // int n = 10000;
            // DateTimeOffset begin = DateTimeOffset.Now;
            // Console.WriteLine($"{begin.Millisecond}");
            // Console.WriteLine($" {n}! = {Sum2(n)}");
            // DateTimeOffset end = DateTimeOffset.Now;
            // Console.WriteLine($"{(end - begin).TotalMilliseconds}");
            // Assembly testAssembly = Assembly.LoadFile(@"C:\CodeGym\Class\C1020K1\APC\Bai1\obj\Debug\net5.0\bai1.dll");
            // Type calcType = testAssembly.GetType("Bai1.Calculator");

            // // create instance of class Calculator
            // object calcInstance = Activator.CreateInstance(calcType);
            // PropertyInfo numberPropertyInfo = calcType.GetProperty("Number");
            // double value = (double)numberPropertyInfo.GetValue(calcInstance, null);
            // Console.WriteLine(value);

            SeniorDeveloper sd = new SeniorDeveloper();
            
            // for(int i=1;i<1000;i+=2){
            //     Console.Write($"{i*i}, ");
            // }

            // for(int i=0;i<n; i++){
            //     for(int j=1;j<m;i+=2){
            //         Console.Write($"{i*i}, ");
            //     }
            // }

            // O(m*n) -> O(n)
        }

        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public static long GiaiThua(int n){
            if(n==1 || n== 0)
                return 1;
            return n*GiaiThua(n-1);
        }

        public static long KDQ(int n){
            long total = 1;
            for(int i=1;i<=n;i++){
                total*=i;
            }
            return total;
        }

        public static long Sum1(int n){
            if(n==0)
                return 0;
            return n+Sum1(n-1);
        }

        public static long Sum2(int n){
            long total = 0;
            for(int i=1; i<=n;i++){
                total +=i;
            }

            return total;
        }

        public long F1(int n){
            if(n==1 || n==0)
                return 1;
            return F1(n-1) + F1(n-2);
        }

        public long F2(int n)
        {
            long f = 0;
            long f1 = 1;
            long f0 = 1;
            int i = 2;

            while(i<n){
                f = f1 + f0;
                f0 = f1;
                f1 = f;
                i++;
            }

            return f;
        }
    }
}
