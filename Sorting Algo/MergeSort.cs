using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting_Algo
{
    public class MergeSort<T>
    {
        public static T[] Sort<T>(T[] arr, int start, int end) where T : IComparable<T>
        {
            if(start == end)
            {
                T[] ans = new T[1];
                ans[0] = arr[start];
                return ans;
            }
            int mid = (start + end) / 2;
            T[] fsh = Sort(arr, start, mid);
            T[] ssh = Sort(arr, mid + 1, end);
            T[] res = MergeTwoSortedArray(fsh, ssh);

            return res;
        }

        public static T[] MergeTwoSortedArray<T>(T[] arr1, T[] arr2) where T : IComparable<T>
        {
            T[] result = new T[arr2.Length + arr1.Length];

            int i = 0, j = 0, k = 0;

            while(i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i].CompareTo(arr2[j]) > 0)
                {
                    result[k++] = arr2[j++]; 
                }
                else
                {
                    result[k++] = arr1[i++];

                }
            }

            while(i < arr1.Length)
                result[k++] = arr1[i++];

            while (j < arr2.Length)
                result[k++] = arr2[j++];

            return result;
        }
       
    }
}
