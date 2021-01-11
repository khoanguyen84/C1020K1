using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class T1
    {

    }

    class T2 : T1
    {

    }

    class T3 : T2
    {

    }

    class Root
    {


    }

    class Branch1: Root
    {

    }

    class Branch2 : Root
    {

    }

    abstract class Human
    {

    }

    interface ISpider
    {
    }

    interface IHorse{

    }

    class Spiderman : Human, ISpider, IHorse
    {

    }

    class Bird
    {

        
    }

    interface IFly
    {

        string HowToFly();

    }

    class Chiken : Bird
    {

    }

    class Eagle : IFly
    {
        public string HowToFly()
        {
            throw new NotImplementedException();
        }
    }

    interface IA
    {
        string HowToA();
    }
    interface IMachine : IFly, IA
    {

    }

    class Airplan : IMachine
    {
        public string HowToA()
        {
            throw new NotImplementedException();
        }

        public string HowToFly()
        {
            throw new NotImplementedException();
        }
    }


}
