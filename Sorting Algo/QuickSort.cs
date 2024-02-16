using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public class QuickSort<T>
    {
        public static void Sort<T>(T[] array, int lo, int hi) where T : IComparable<T> 
        {
            if(lo >= hi)
                return;

            T pivot = array[hi];
            int pi = PartitionArray(array, lo, hi, pivot);
            Sort(array, lo, pi - 1);
            Sort(array, pi + 1, hi);

        }

        public static int PartitionArray<T>(T[] array, int start, int end, T pivot) where T : IComparable<T>
        {
            int i = start, j = start;
            while(i <= end)
            {
                if (array[i].CompareTo(pivot) > 0)
                {
                    i++;
                }
                else
                {
                    //swap
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j++;
                }
            }

            return j - 1;
        }


    }
}
