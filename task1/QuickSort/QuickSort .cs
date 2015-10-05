using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class QuickSort:IQuickSort
    {
        public void Sort(int []arr, int left, int right) //реализация интерфеса
        {
            int i, j;
            i = left;
            j = right;
            int midle = arr[(i + j) / 2];
            do
            {
                while (midle > arr[i]) i++;
                while (midle < arr[j]) j--;
                if (i <= j)
                {
                    int buff = arr[i];
                    arr[i] = arr[j];
                    arr[j] = buff;

                    i++;
                    j--;
                }
            } while (i < j);
            if (i < right) Sort(arr,i, right);
            if (j > left) Sort(arr,left, j);
        }
    }
}
