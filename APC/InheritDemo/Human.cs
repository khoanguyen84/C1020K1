using System;
namespace InheritDemo
{
    class Human : Object
    {

        public override string ToString()
        {
            return $"{base.ToString()} Hello from Human";
        }

    }
}