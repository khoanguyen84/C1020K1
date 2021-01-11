using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     int a = 5;
            //     int b = 0;
            //     int[] arr = new int[3]{1,2,3};
            //     Console.WriteLine(arr[3]);
            //     Console.WriteLine($"{a} : {b} = {a/b}");                
            // }
            // catch(System.IndexOutOfRangeException ex){
            //     Console.WriteLine("Sai index roi nhe.");
            // }
            // catch(System.DivideByZeroException ex)
            // {
            //     Console.WriteLine("Khong the chia cho 0.");
            // }
            // catch (System.Exception ex)
            // {
            //     Console.WriteLine($"{ex.GetType()}, {ex.Message}");
            // }
            // B b = new B();
            // try
            // {
            //     b.MyMath();
                
            // }
            // catch (System.Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            
            try
            {
                int n = 6;
                if(n !=5)
                    throw new MyException(n);

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class A
    {
        public int Divide(int a, int b){
            try
            {
                return a/b;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Error");
            }
        }
    }

    class B
    {
        public void MyMath(){
            A a = new A();
            Console.WriteLine(a.Divide(5,0));
        }
    }

    class MyException: System.Exception{
        public MyException(int n) : base($"{n} is not prime")
        {
            
        }
    }
}
