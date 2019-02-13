using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CustomList<T> : IEnumerable
    {

        public int Count { get; set; }
        private int count;
        public int Compacity;
        private T[] items;
        public T[] tempArr;
        public int Index;
        int x;
        public T this[int index]  // Indexer declaration  
        {
            get
            {
                return items[index];
              
            }
            set
            {
                if (index > count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    items[index] = value;
                }

                
            }
            // get and set accessors  
        }

        public CustomList()
        {
            x = 0;
            count = 0;
            Compacity = 4;
            items = new T[Compacity];
            tempArr = new T[Compacity];
        }
        public void Add(T item)
        {

            items[Index] = item;
            Index++;
            Count++;
            if (Count == Compacity)
            {
                tempArr = items;
                Compacity += Compacity;
                items = new T[Compacity];
                for (int i = 0; i < Count; i++)
                {
                    items[i] = tempArr[i];
                }
            }
            return;
            //add thing             
        }
        public void Remove(T item)
        {


            for (int i = 0; i < Count; i++)
            {
                if (!item.Equals(items[i]))
                {

                    tempArr[x] = items[i];
                    count++;
                    x++;

                }

                else if (Count < 2)
                {
                    items = tempArr;
                }

            }                 
            if (!count.Equals(Count))
            {
                Count += -1;
            }

            items = tempArr;
            x = 0;

            return;
        }
        public override string ToString()
        {
            string putTogether = "";
            for (int i = 0; i < Count; i++)
            {
                putTogether = putTogether + items[i];
            }
            return putTogether;
        }
        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> custom = new CustomList<T>();
            for (int i = 0; i < a.Count; i++)
            {
                custom.Add(a.items[i]);
            }
            for (int i = 0; i < b.Count; i++)
            {
                  
                    custom.Add(b.items[i]);
            }
            return custom;
        }
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            foreach(T item in a.items)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    if (item.Equals(b.items[i]))
                    {
                        a.Remove(item);
                    }
                }    
            }
            return a;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                yield return""; 
            }
            yield return "No more Teams";

        }
        public static CustomList<T> Zip(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> custom = new CustomList<T>();
            int highercount = 0;

            if(firstList.count > secondList.count)
            {
                highercount = firstList.Count;
            }
            else
            {
                highercount = secondList.Count;
            }
            for (int i = 0; i < highercount; i++)
            {
                if (firstList.count > i)
                {
                    custom.Add(firstList.items[i]);
                }            
                if(secondList.Count > i)
                {
                    custom.Add(secondList.items[i]);
                }
            }

            return custom;
        }
        public void Sort(CustomList<T> comparison)
        {
          
           
        }

        //public int CompareTo(object obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
