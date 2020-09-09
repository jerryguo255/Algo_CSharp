using System;
using System.Diagnostics;
using System.Threading;
using Lib_0509_FibonacciNumber;
namespace Performance_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            TimeSpan ts;
            var stopWatch = new Stopwatch();


            #region fib result

            stopWatch.Start();
            ts = stopWatch.Elapsed;

            Console.WriteLine($"Start Time :{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds :0000}");
            //Thread.Sleep(2000);

            s.Fib(1000);
           

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine($"End Time :{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds :0000}");



            #endregion

            //#region fib Recursion result
            //stopWatch.Reset();
            //stopWatch.Start();
            //ts = stopWatch.Elapsed;

            //Console.WriteLine($"Start Time :{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds / 10:00}");
            ////Thread.Sleep(2000);
            //for (int i = 0; i < 50; i++)
            //{
            //    s.FibRecursion(35);
            //}

            //stopWatch.Stop();
            //ts = stopWatch.Elapsed;
            //Console.WriteLine($"End Time :{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds / 10:00}");


            //#endregion


            Console.ReadLine();

        }
        static unsafe void DisplaySizeOf<T>() where T : unmanaged
        {
            Console.WriteLine($"Size of {typeof(T)} is {sizeof(T)}");
        }


    }


    public class Solutions
    {
        public int MySqrtBF(int x)
        {
            var result = 0;



            for (int i = 1; i <= x; i++)
            {
                if (x / i == i)
                {
                    result = i;
                    break;
                }


                if (x / i < i)
                {
                    result = i - 1;
                    break;
                }

            }
            return result;
        }
    }

}
