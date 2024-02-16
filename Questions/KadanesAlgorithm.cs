using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions
{
    public class KadanesAlgorithm
    {

        public static int MaxSumSubarray(int[] arr, out string maxSumSubArray)
        {
            int csum = 0;
            maxSumSubArray = "";
            string temp = "";
            int maxsum = Int32.MinValue;
            for(int i = 0; i < arr.Length; i++) 
            {
                csum += arr[i];
                if (arr[i] > csum)
                {
                    temp = arr[i] + " ";
                    csum = arr[i];
                }
                else
                {
                    temp += arr[i] + " ";
                }
                if(csum > maxsum)
                {
                    maxsum = csum;
                    maxSumSubArray = temp;
                }
               
            }

            return maxsum;
        }
    }
}
