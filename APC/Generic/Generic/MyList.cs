using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class MyList<T> where T : class
    {
        private T[] list;
        private int index = 0;
        public int Count => index;
        public int Capacity { get; set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public MyList()
        {
            Capacity = 0;
            list = new T[Capacity];
        }

        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if(index >=0 && index < Count)
                {
                    return list[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    list[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }

        public void Add(T item)
        {
            if (Capacity == 0)
            {
                Capacity = 4;
                Array.Resize(ref list, Capacity);
            }
            else if(index >= Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref list, Capacity);
            }
            list[index++] = item;
        }

        public void AddRange(T[] items)
        {
            for(int i =0; i < items.Length; i++)
            {
                Add(items[i]);
            }
        }
    }
}
