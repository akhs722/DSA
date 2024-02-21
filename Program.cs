using DSA.Questions.Arrays;
using DSA.Questions.DP;
using DSA.Sorting_Algo;
using System.Linq;

namespace DSA.Program
{

    public class Program
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[7];
            int ans = Fibonacci.MemoizedFibonacciFunction(6, arr);
            Console.WriteLine(ans);
        }
    }
}