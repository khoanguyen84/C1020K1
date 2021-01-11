using System;
namespace Bai1
{
    public class Number
    {
        public int Number1  { get; set; }
        public int Number2 { get; set; }
        private int number3;
        private int number4;
        private int number5;

        public static double Pi = 3.14;

        public Number()
        {
            
        }

        public Number(int n3)
        {
            number3 = n3;
        }

        public Number(int n3, int n4, int n5)
        {
            number3 = n3;
            number4 = n4;
            number5 = n5;            
        }

        public void SetNumber3(int n){
            number3 = n;
        }
        public int GetNumber3(){
            return number3;
        }
        public int Number4{
            get { return number4;}
            set { number4 = value;}
        }

        public int Number5{
            get => number5;
            set => number5 = value;
        }
        public void Swap(){
            int temp = Number1;
            Number1 = Number2;
            Number2=temp;
        }

        public static string Sologen(){
            return "still breath still alive";
        }
    }
}