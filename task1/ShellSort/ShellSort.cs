using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class ShellSort:IShellSort
    {
        public void Sort(int []arr) //реализация интерфеса
        {
            int j;
            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < arr.Length; ++i)
                {
                    int temp = arr[i];
                    for (j = i; j >= gap && temp < arr[j - gap]; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }
    }
}
