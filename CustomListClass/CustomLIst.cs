using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// custom built list to store any data type 
// read only count property
// c# indexer accessible via index, cannot access an out of bounds index
// add object to an instance of list class
// override tostring method to convert list to string
// overload the + operator to add 2 instances
// overload the - operator to subtract 2 instances 
// write details of operator overload - check userstories
// zip 2 columns together (zipper)


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
            capacity = 0;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T toAdd)
        {
                if (count >= capacity)
                {
                increaseList(capacity);
            }
            items[count] = toAdd;
            count++;
            capacity++;
        }

        public bool Remove(T toRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(toRemove))
                {
                    items[i] = items[i + 1];
                    i++;
                }
            }
            count--;
            capacity--;
            return true;
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
