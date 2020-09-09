using System;
using System.Collections.Generic;

namespace Lib_0509_FibonacciNumber
{
    public class Solution
    {
        public long Fib(long n)
        {
            long f2 = 1;
            long f3 = 2;
            long result = 0;
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return f2;
                case 3:
                    return f3;
            }

            for (long i = 3; i < n; i++)//6  : 3  , 4  , 5
            {
                result = f2 + f3;   // 3 = 1 + 2
                f2 = f3;            // f2 = 2;
                f3 = result;        // f3 = 3;
            }

            return result;
        }
        long[] memo = new long[1000];

        public long FibRecursion(long n)
        {

            if (memo[n] != 0)
            {
                return memo[n];
            }


            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                case 2:
                    return 1;
                default:
                    {
                        memo[n] = FibRecursion(n - 1) + FibRecursion(n - 2);

                        return memo[n];
                    }
            }
        }

        public decimal GoldenRatio()
        {

            var first = Fib(77);
            var second = Fib(78);
            var goldenRatio = (decimal)first / second;
            return goldenRatio;
            Console.WriteLine($"{first} / {second} = {goldenRatio}");
            Console.ReadLine();
        }


    }
}
