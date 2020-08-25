using System;
using System.Collections.Generic;
using System.Linq;
using Lib_0150_EvaluateReversePolishNotation;


namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
          
           var ss = new[] {"2", "1", "+", "3", "*"};

           var s = new Solution();
           

           Console.WriteLine(s.EvalRPN(ss));
            Console.ReadLine();
        }


    }


}
