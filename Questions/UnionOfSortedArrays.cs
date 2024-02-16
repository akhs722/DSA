using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions
{
    public class UnionOfSortedArrays
    {

        public static List<int> Union(int[] arr1, int[] arr2)
        {
            SortedSet<int> set = new();
            foreach (int i in arr1) 
            {
                set.Add(i);
            }

            foreach (int i in arr2)
            {
                set.Add(i);
            }

            List<int> res = new List<int>(set);

            return res;
        }
    }
}
