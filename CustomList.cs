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
                items[index] = value;
            }
            // get and set accessors  
        }

        public CustomList()
        {
            x = 0;
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


                    x++;

                }
                else if (Count < 2)
                {

                    items = tempArr;
                }

            }

            Count += -1;
            x = 0;

            items = tempArr;

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
        public static CustomList<T> operator+ (CustomList<T> a, CustomList<T> b)
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
            CustomList<T> custom = new CustomList<T>();
            for (int i = 0; i < a.Count; i++)
            {
                if (!a.items[i].Equals(b.items[i]))
                {
                    custom.Add(a.items[i]);
                }
                
            }
       
            return custom;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                //yield return westernConference[index];
                //yield return easternConference[index];
            }
            yield return "No more Teams";

        }
    }
}
