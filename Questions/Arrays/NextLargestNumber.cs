using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions.Arrays
{
    public class NextLargestNumber
    {
        public static void GetNextPermutation(int[] arr)
        {
            int breakPoint = -1;
            //Find the break point

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                    breakPoint = i;
            }
            if (breakPoint == -1)
                arr.Reverse();



            else
            {
                Console.WriteLine($"BreakPoint {breakPoint}");
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] > arr[breakPoint])
                    {
                        //swap
                        int temp = arr[i];
                        arr[i] = arr[breakPoint];
                        arr[breakPoint] = temp;
                        break;
                    }
                }
                Console.WriteLine(string.Join(",", arr));
                //Now After swapping your series will be again in increasing order till the breakpoint, 
                //Now swap everything to make it in decreasing order after the break point index

                Reverse(arr, breakPoint + 1, arr.Length - 1);
            }
        }

        public static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }
    }
}
