using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
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

        public void Remove()
        {

        }
    }
}
