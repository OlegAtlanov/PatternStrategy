using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n"+new string('-', 30) + " Quick_Sort\n");
            Sort s = new Quick_Sort();
            int[] arr = new int[]{3,2,3,2,23,1,8,8,56};
            s.Show(arr);
            s.QSort(arr, 0, (arr.Length-1));
            Console.WriteLine();
            s.Show(arr);
            int[] arr_1 = new int[] { 33, 2, 3, 2, 23, 1, 18, 8, 56,4,23,1,34,67};
            Console.WriteLine("\n"+ new string('-', 30) + " Insertion_Sort\n");
            s = new Insertion_Sort();
            s.Show(arr_1);
            s.ISort(arr_1);
            Console.WriteLine();
            s.Show(arr_1);
            int[] arr_2 = new int[] { 33, 2, 3, 2, 23, 1, 18, 8, 56, 4, 23, 1, 34, 67, 43, 12, 345, 32, 76, 1 };
            Console.WriteLine("\n" + new string('-', 30) + " Shell_Sort\n");
            s = new Shell_Sort();
            s.Show(arr_2);
            s.ShSort(arr_2);
            Console.WriteLine();
            s.Show(arr_2);
            Console.ReadKey();
        }
    }
}
