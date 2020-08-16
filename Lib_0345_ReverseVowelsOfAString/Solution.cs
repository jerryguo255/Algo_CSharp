using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib_0345_ReverseVowelsOfAString
{
    public class Solution
    {
        Stack<int> indexList = new Stack<int>();
        List<char> vowelList = new List<char>();
        string vowels = "aeiouAEIOU";
        private char[] output;
        public string ReverseVowels(string s)
        {
            for (var i = 0; i < s.Length; i++)
            {
                foreach (var unused in vowels.Where(t => s[i] == t))
                {
                    indexList.Push(i);
                    vowelList.Add(s[i]);
                }
            }
            output = s.ToCharArray();

            foreach (var vowel in vowelList)
            {
                output[indexList.Pop()] = vowel;
            }
            return new string(output);

        }
    }

}
