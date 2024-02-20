using DSA.Questions;
using DSA.Sorting_Algo;
using System.Linq;

namespace DSA.Program
{

    public class Program
    {
        public static void Main(string[] args)
        {

            int[][] arr = new int[4][] 
            {
                new int[] { 1, 3},
                new int[] { 8, 10 },
                new int[] { 2, 6 },
                new int[] { 15, 18 },
            }; 
            
            
            var res  = MergeOverlappingIntervals.MergeOverlappingIntervalsFunction(arr);
            
            //Print and check the res
        }
    }
}