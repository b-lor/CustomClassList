using System;
using System.Collections;
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
    public class CustomList<T> : IEnumerable
    {
        private T[] items;

        public int Count { get { return count; } }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value >= count)
                    capacity = value;
                else
                    throw new Exception("Index out of Bound");
            }
        }
        private int count;
        private int capacity { get; set; }

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public CustomList(int aSize = 0)
        {
            items = new T[0];
            count = 0;
            capacity = aSize;
        }

        public void increaseList()
        {
            if (capacity == 0)
            {
                capacity = 1;
            }
            capacity = 2 * capacity;
        }

        public void Add(T toAdd)
        {
            if (capacity == 0 || count >= capacity)
            {
                increaseList();
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
            items[count++] = toAdd;
        }

        public bool Remove(T toRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (Comparer<T>.Default.Compare(items[i], toRemove)==0)
                {
                    for (; i < count; i++)
                    {
                        if (i < count - 1)
                        {
                            items[i] = items[i + 1];
                        }
                    }
                    count--;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index >= count || index < 0)
                return false;
            else
            {
                for (int i = index; i < count; i++)
                {
                    if (i < count - 1)
                        items[i] = items[i + 1];
                }
                count--;
                return true;
            }
        }

        public override string ToString()
        {
            string isString = "";
            for (int i = 0; i < count; i++)
            {
                if (isString == "")
                    isString = "" + items[i];
                {
                    isString = isString + " " + items[i];
                }
            }
            return isString;
        }

        //public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        //{
        //    CustomList<T> plusOperator = new CustomList<T>();
        //    for (int i = 0; i < listOne.count; i++)
        //    {
        //        plusOperator.Add(listOne.items[i]);
        //    }
        //    for (int i = 0; i < listTwo.count; i++)
        //    {
        //        plusOperator.Add(listTwo.items[i]);
        //    }
        //    return plusOperator;
        //}

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> plusOperator = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                dynamic listOneList = listOne[i];
                dynamic listTwoList = listTwo[i];
                T temp = (T)(listOneList + listTwoList);
                plusOperator.Add(temp);
            }
            return plusOperator;
        }
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> minusOperator = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                dynamic listOneList = listOne[i];
                dynamic listTwoList = listTwo[i];
                T temp = (T)(listOneList - listTwoList);
                minusOperator.Add(temp);
            }
            return minusOperator;
        }

        public static CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> zipperList = new CustomList<T>(listOne.count + listTwo.count);
            for (int i = 0; i < listOne.count; i++)
            {
                zipperList.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                zipperList.Add(listTwo[i]);
            }
            return zipperList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
          
        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return (IEnumerable)GetEnumerator();
        }
    }
}