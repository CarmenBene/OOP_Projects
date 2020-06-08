using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {15,18,3,25,14,11,30,26,7};
            int n = array.Length;
            HeapSort a = new HeapSort();

            a.Sort(array);

            Console.WriteLine("Sorted array is");
            a.Print(array);
        }
    }
}
