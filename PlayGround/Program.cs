using System;
using System.Collections.Generic;
using System.Linq;
using Lib_1381_DesignAStackWithIncrementOperation;



namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new CustomStack(3);
            s.Push(1);
            s.Push(2);

            s.Push(3);

            s.Increment(5,20);

            var vals = new int[s.MaxSize];
            for (int i = 0; i < s.MaxSize; i++)
            {
                vals[i] = s.Pop();
            }

            foreach (var i in vals.Reverse()) Console.WriteLine(i);
          


            Console.ReadLine();
        }


    }


}
