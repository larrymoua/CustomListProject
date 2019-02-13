using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> customList1 = new CustomList<int>() { 2, 3, 5, 8, 9 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 8, 6, 1, 7 };


            CustomList<int> myList = new CustomList<int>() { 1, 3, 2 };
            CustomList<int> myList1 = new CustomList<int>() { 3, 1, 1 };

            CustomList<int> customList = new CustomList<int>();

            //Act
            customList = CustomList<int>.Zip(myList, myList1);

            Console.WriteLine(customList);
            Console.ReadLine();
        }
    }
}
