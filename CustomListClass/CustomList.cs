using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        //Member Variables
        private T[] itemArr = new T[4];
        public T this[int index]
        {
            get => itemArr[index];
            set => itemArr[index] = value;
        }
        private int count;
        public int Count
        {
            get { return count; }
        }
        private int capacity=4;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        //Constructor


        //Member Methods

        

        public void Add(T item)
        {
            if (count == capacity)
            {
                T[] increasedArray = new T[capacity *= 2];
                for (int i = 0; i < Count; i++)
                {
                    increasedArray[i] = itemArr[i];
                }
                itemArr = increasedArray;
            }
            itemArr[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            bool itemFound = false;
            T[] newArray = new T[capacity];
            for (int i = 0, j = 0; i < Count; i++, j++)
            {
                if (itemArr[i].Equals(item) && itemFound == false)
                {
                    itemFound = true;
                    j--;
                }
                else
                {
                    newArray[j] = itemArr[i];
                }
            }
            if (itemFound == true)
            {
                count--;               
            }
            itemArr = newArray;
            return itemFound;
        }
        public CustomList<T> Zipper(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            int j = 0;
            if(list1.Count == list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    newList.Add(list1[i]);
                    newList.Add(list2[i]);
                }
            }
            else if (list1.Count > list2.Count)  
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    newList.Add(list1[i]);
                    newList.Add(list2[i]);
                    j++;
                }
                for (int i = j; i < list1.Count;  i++)
                {
                    newList.Add(list1[i]);
                }
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    newList.Add(list1[i]);
                    newList.Add(list2[i]);
                    j++;
                }
                for (int i = j; i < list2.Count; i++)
                {
                    newList.Add(list2[i]);
                }
            }
            
            return newList;
        }

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < Count; i++)
            {
                if (i+1 == Count)
                {
                    newString = newString + itemArr[i];
                }
                else
                {
                    newString = newString + itemArr[i] + " ";
                }
            }
            return newString;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return itemArr[i];
            }
        }

        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList= new CustomList<T>();

            for (int i = 0; i < list1.Count; i++)
            {
                newList.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }
        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            
            for (int i = 0; i < list1.Count; i++)
            {
                foreach (T item in list2)
                {
                  list1.Remove(item);
                }
            }
            newList = list1;
            return newList;
        }
    }
}
