using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions
{
    public class ThreeSum
    {
        public static IList<IList<int>> TwoSumMethod(int[] nums, int sum)
        {
            IList<IList<int>> res = new List<IList<int>>(); 
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == sum)
                    {
                        List<int> temp = new();
                        temp.Add(nums[i]);
                        temp.Add(nums[j]);
                        res.Add(temp);
                    }
                }
            }
            return res;
        }

        public static IList<IList<int>> ThreeSumMethod(int[] nums)
        {

            IList<IList<int>> finalRes = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0 - nums[i];
                var res = TwoSumMethod(nums, sum);
                if (res != null && res.Any())
                {
                    foreach (var list in res)
                    {
                        list.Add(nums[i]);
                        finalRes.Add(list);
                    }
                        

                   
                        
                }
            }
            return finalRes;
        }
    }
}
