using System;

namespace Lib_0367_ValidPerfectSquare
{
    public class Solution
    {


        /// <summary>
        /// Given a positive integer num, write a function which returns True if num is a perfect square else False.
        /// Follow up: Do not use any built-in library function such as sqrt
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsPerfectSquare(int num)
        {
            var fact=false;
            // 16 / 2 = 8  ;    8 / 2 = 4;   4/ 2 = 2;   2 / 2 ==1;

            for (var i = 1; i <= num; i++)
            {
                var res = num / i;
                var mod = num % i;
                if (res == i && mod == 0)
                {
                    fact = true;
                    break;
                }

                if (res <i)
                {
                    break;
                }
            }
            return fact;
        }

    }
}
