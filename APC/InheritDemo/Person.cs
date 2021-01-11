using System;

namespace InheritDemo
{
    class Person : Object
    {
        public string FirstName { get; set; }
        protected string lastName { get; set; }

        public Person()
        {
            
        }
        ~ Person(){

        }

        public Person(string fn, string ln)
        {
            FirstName =fn;
            lastName = ln;
        }

        public virtual string ShowInfo()
        {
            return $"{FirstName}\t\t{lastName}";
        }

        public override string ToString()
        {
            return $"{FirstName}\t\t{lastName}";
        }

        public virtual int Sum(int number1, int number2){
            var sum = number1 + number2;
            return sum;
        }
    }
}