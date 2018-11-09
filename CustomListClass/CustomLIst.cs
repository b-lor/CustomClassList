using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// custom built list to store any data type 
// read only count property-
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
        public int Capacity { get { return capacity; } set { capacity = value; } }

        private int count;
        private int capacity { get; set; }

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public CustomList()
        {
            items = new T[0];
            count = 0;
        }

        public void increaseList()
        {
            if (count >= capacity)
            {
                    capacity++;
            }
            capacity = count;
        }

        public void Add(T toAdd)
        {
            T[] tempArray = new T[items.Length + 1];
            count++;
            increaseList();
            for (int i = 0; i < items.Length; i++)
            {
                tempArray[i] = items[i];
            }
            tempArray[tempArray.Length - 1] = toAdd;
            items = tempArray;
        }


        public bool Remove(T toRemove)
        {
            bool result = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(toRemove))
                {
                    int removeIndex = i;
                    for (int j = removeIndex; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    capacity--;
                    result = true;
                }
            }
            return result;
        }


        public override string ToString()
        {
            string isString = "";
            isString = items[0].ToString();
            for (int i = 1; i < count; i++)
            {
                isString = items[i].ToString();
            }
            return isString;
        }

    }
}