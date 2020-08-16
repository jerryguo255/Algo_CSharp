using System;

namespace Lib_0344_ReverseString
{
    public class Solution
    {
        private char _temp = ' ';
        public char[] ReverseString(char[] s)
        {
            //for (int i = s.Length; i < 0; i--)
            //{
            //    s[i]
            //}
            int end = s.Length - 1;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length / 2)
                {
                    _temp = s[end-i];
                    s[end-i] = s[i];
                    s[i] = _temp;
                }
                else
                {
                    break;
                }
                
            }




            return s;
        }



    }
}

