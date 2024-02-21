using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions.Arrays
{
    public class LargestSubarrayWithZeroSum
    {
        public static int GetLargestSubarrayWithZeroSum(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int maxi = int.MinValue;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum == 0)
                {
                    maxi = i > maxi ? i + 1 : maxi;
                }
                else
                {
                    if (map.ContainsKey(sum))
                    {
                        maxi = Math.Max(maxi, i - map[sum]);
                    }
                    else
                    {
                        map.Add(sum, i);
                    }
                }
            }

            return maxi;
        }
    }
}
