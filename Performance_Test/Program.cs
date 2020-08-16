using System;
using System.Diagnostics;
using System.Threading;
using Lib_0069_SqrtX;
namespace Performance_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            TimeSpan ts;

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            ts = stopWatch.Elapsed;

            Console.WriteLine($"Start Time :{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds / 10:00}");
            //Thread.Sleep(2000);
            for (int i = 0; i < 50_000; i++)
            {
                s.MySqrt(int.MaxValue);
            }
            Console.WriteLine(s.MySqrt(int.MaxValue));
           
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine($"End Time :{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds / 10:00}");

            Console.ReadLine();

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
