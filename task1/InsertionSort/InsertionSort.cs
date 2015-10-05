using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class InsertionSort:IInsertionSort
    {
        public void Sort(int []arr) //реализация интерфеса
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int buff = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buff;
                    }
                }
            }
        }
    }
}
