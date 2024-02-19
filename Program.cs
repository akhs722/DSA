using DSA.Questions;
using DSA.Sorting_Algo;

namespace DSA.Program
{

    public class Program
    {
        public static void Main(string[] args)
        {

            int[] arr = new[] {6, -2, 2, -8, 1, 7, 4, -10};
            int[] arr2 = new[] {1, 0, -5};
            var res  = LargestSubarrayWithZeroSum.GetLargestSubarrayWithZeroSum(arr);
            Console.WriteLine(res);
        }
    }
}