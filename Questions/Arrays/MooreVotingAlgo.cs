using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions.Arrays
{
    public class MooreVotingAlgo
    {
        public static int MostFrequentElement(int[] arr)
        {
            int candidate = arr[0];
            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (count == 0)
                {
                    count = 1;
                    candidate = arr[i];
                }
                else if (candidate == arr[i]) count++;

                else count--;


            }

            return candidate;
        }
    }
}
