using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions.Arrays
{
    public class SetZeroesMatrix
    {
        public static void SetZeroes(int[][] arr)
        {
            int[] row = new int[arr.Length];
            int[] col = new int[arr[0].Length];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == 0)
                    {
                        row[i] = 1;
                        col[j] = 1;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (row[i] == 1 || col[j] == 1)
                    {
                        arr[i][j] = 0;
                    }

                }
            }


        }
    }
}
