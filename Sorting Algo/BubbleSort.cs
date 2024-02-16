using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public class BubbleSort<T>
    {

        public static void Sort<T>(T[] array) where T : IComparable<T> 
        {
            if(array == null || array.Length == 0)  return;

            else
            {

                //{ 5,1,2,-1,7,0}
                // 1st iteration  => {1,2,-1,5,0,7}
                for (int i = 0; i < array.Length; i++) 
                {
                    for(int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }

    }
}
