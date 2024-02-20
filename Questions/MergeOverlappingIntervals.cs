using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions
{
    public class MergeOverlappingIntervals
    {
        public static List<List<int>> MergeOverlappingIntervalsFunction(int[][] arr)
        {

            List<List<int>> ans = new List<List<int>>();

            ans.Add(new List<int>(arr[0]));
            //First Sort this array

            Array.Sort(arr, (a, b) => a[0].CompareTo(b[0]));

            //Once it is sorted out then 
           
            for (int i = 1; i < arr.Length; i++)
            {
                
                //This means that the overlapping is going to happen
                if (arr[i][0] <= ans[ans.Count - 1][1])
                {
                    ans[ans.Count - 1][1] = arr[i][1] < ans[ans.Count - 1][1] ? ans[ans.Count - 1][1] : arr[i][1];
                }
                else
                {
                    ans.Add(new List<int>(arr[i]));
                }
            }

            return ans;
        }
    }
}
