using System;
using System.Collections;

namespace Collection
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);

            while(st.Count > 0){
                Console.WriteLine(st.Pop());
            }
        }
    }
}
