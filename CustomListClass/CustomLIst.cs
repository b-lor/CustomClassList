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
                    throw new ArgumentOutOfRangeException();
            }
        }
        private int count;
        private int capacity { get; set; }

        //public T this[int i]
        //{
        //    get { return items[i]; }
        //    set { items[i] = value; }
        //}

        public T this[int i]
        {
            get
            {
                if (i >= count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[i];
            }
            set
            {
                if (i >= count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[i] = value;
            }
        }

        public CustomList(int aSize = 0)
        {
            try
            {
                items = new T[0];
                count = 0;
                capacity = aSize;
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public CustomList(T[] input)
        {
            count = input.Length;
            try
            {
                capacity = count;
                items = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    items[i] = input[i];
                }
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
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
                {
                    isString = "" + items[i];
                }
                else
                {
                    isString = isString + " " + items[i];
                }
            }
            return isString;
        }


        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> plusOperator = new CustomList<T>();
            foreach (T item in listOne)
            {
                plusOperator.Add(item);
            }
            foreach (T item in listTwo)
            {
                plusOperator.Add(item);
            }
            return plusOperator;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> minusOperator = new CustomList<T>();
            foreach (T item in listTwo)
            {
                foreach (T items in listOne)
                {
                    if (object.Equals(item, items))
                    {
                        listOne.Remove(item);
                    }
                }
            }
            return listOne;
        }

        public static CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> zipperList = new CustomList<T>();
            int zip = listOne.Count;
            if (listOne.Count < listTwo.Count)
            {
                zip = listTwo.Count;
            }
            for (int i = 0; i < zip; i++)
            {
                try
                {
                    zipperList.Add(listOne[i]);
                }
                catch (ArgumentOutOfRangeException)
                {

                }
                try
                {
                    zipperList.Add(listTwo[i]);
                }
                catch (ArgumentOutOfRangeException)
                {

                }
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