using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        T[] items = new T[1];

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }

        private int count;
        private int capacity;

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public CustomList()
        {
            capacity = 1;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T toAdd)
        {
            if (count >= capacity - 1)
            {
                increaseList(capacity);
            }
            items[count] = toAdd;
            count++;
        }

        public int increaseList(int capacity)
        {
            capacity = count + 1;
            T[] newArray = new T[capacity];

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
            return capacity;
        }
    }
}
