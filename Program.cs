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
            CustomList<int> customList = new CustomList<int>() { 1,3, 5};
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> list = new CustomList<int>();
            list = CustomList<int>.Zip(customList, customList2);
            Console.WriteLine(list);
            Console.ReadLine();


        }
    }
}
