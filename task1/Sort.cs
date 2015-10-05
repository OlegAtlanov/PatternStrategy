using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    abstract class Sort
    {
        protected IInsertionSort insertionBehavior;
        protected IQuickSort quickBehavior;
        protected IShellSort shellBehavior;
        public Sort()
        {
            insertionBehavior = new InsertionSort();
            quickBehavior = new QuickSort();
            shellBehavior = new ShellSort();
        }
        public void QSort(int []arr,int left,int right)
        {
            quickBehavior.Sort(arr,left,right);
        }
        public void ISort(int[] arr)
        {
            insertionBehavior.Sort(arr);
        }
        public void ShSort(int[] arr)
        {
            shellBehavior.Sort(arr);
        }
        public abstract void Show(int[] arr);
        

    }
    /// <summary>
    /// //////////////////////////////////Quick Sort
    /// </summary>
    class Quick_Sort : Sort
    {
        public Quick_Sort()
        {
            quickBehavior = new QuickSort();
        }
        public override void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
        }
    }
    /// <summary>
    /// /////////////////////////Insertion Sort
    /// </summary>
    class Insertion_Sort : Sort
    {
        public Insertion_Sort()
        {
            insertionBehavior = new InsertionSort();
        }
        public override void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
        }
    }
    /// <summary>
    /// /////////////////////////Shell Sort
    /// </summary>
    class Shell_Sort : Sort
    {
        public Shell_Sort()
        {
            shellBehavior = new ShellSort();
        }
        public override void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
        }
    }
}
