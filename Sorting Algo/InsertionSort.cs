using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public class InsertionSort<T>
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {

            for(int i = 1; i < array.Length; i++) 
            {
                for(int j = i; j > 0; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) > 0)
                        break;

                    else
                    {
                        //swap
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
