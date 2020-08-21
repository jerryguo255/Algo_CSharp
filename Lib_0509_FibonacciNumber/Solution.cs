using System;

namespace Lib_0509_FibonacciNumber
{
    public class Solution
    {
        public Int64 Fib(Int64 n)
        {
            Int64 f2 = 1;
            Int64 f3 = 2;
            Int64 result = 0;
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
           
            for (int i = 3; i < n; i++)//6  : 3  , 4  , 5
            {
                result = f2 + f3;   // 3 = 1 + 2
                f2 = f3;            // f2 = 2;
                f3 = result;        // f3 = 3;
            }

            return result;
        }

        public int FibRecursion(int n)
        {
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                case 2:
                    return 1;
                default:
                {
                    return FibRecursion(n - 1) + FibRecursion(n - 2);
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
