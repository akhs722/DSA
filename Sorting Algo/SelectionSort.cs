using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public static class SelectionSort<T>
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            if (array == null || array.Length == 0)
                return;

            else
            {
                //{ 5,1,2,-1,7,0};
                int min = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    min = i;
                    for(int j = i + 1; j < array.Length; j++)
                    {
                        if (array[min].CompareTo(array[j]) > 0)
                        {
                            min = j;
                        }
                    }
                    //swap with minimum
                    T temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;  
                }
            }

        }



    }
}
