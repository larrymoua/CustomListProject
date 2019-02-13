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

            CustomList<int> customList = new CustomList<int>() { 2, 3, 5, 8, 9 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 8, 6, 1, 7 };
            CustomList<int> result = customList - customList2;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
