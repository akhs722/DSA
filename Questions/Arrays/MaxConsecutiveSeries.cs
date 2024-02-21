using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions.Arrays
{
    public class MaxConsecutiveSeries
    {
        public static int MaxConsecutive(int[] arr)
        {
            Dictionary<int, int> map = new();

            foreach (int ele in arr)
            {
                if (map.ContainsKey(ele))
                {
                    map[ele] = ++map[ele];
                }
                else
                {
                    map.Add(ele, 1);
                }
            }
            int maxCount = int.MinValue;
            foreach (int ele in arr)
            {
                int count = 1;
                if (map.ContainsKey(ele - 1))
                {
                    count++;
                    int num = ele - 2;
                    while (map.ContainsKey(num))
                    {
                        num--;
                        count++;
                    }
                }

                maxCount = count > maxCount ? count : maxCount;
            }

            return maxCount;
        }
    }
}
