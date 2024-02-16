using DSA.Questions;
using DSA.Sorting_Algo;

namespace DSA.Program
{

    public class Program
    {
        public static void Main(string[] args)
        {

            int[][] arr = new int[3][]
                {
                    new int[] { 0,1,2,0 }, 
                    new int[] { 3,4,5,2 }, 
                    new int[] { 1,3,1,5 } 
                };
            SetZeroesMatrix.SetZeroes(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Row " + i + ": " + String.Join(", ", arr[i]));
            }
        }
    }
}