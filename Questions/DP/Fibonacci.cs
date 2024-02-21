using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Questions.DP
{
    public class Fibonacci
    {
        public static int MemoizedFibonacciFunction(int n, int[] qb)
        {
            if (n == 0 || n == 1) return n;

            if (qb[n] != 0)
                return qb[n];

            int fib1 = MemoizedFibonacciFunction(n - 1, qb);
            int fib2 = MemoizedFibonacciFunction(n - 2, qb);

            var res = fib1 + fib2;
            qb[n] = res;
            return res;
        }
    }
}
