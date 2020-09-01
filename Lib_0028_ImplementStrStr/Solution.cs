using System;

namespace Lib_0028_ImplementStrStr
{
    public class Solution
    {
        int firstSameCharIndex = 0;
        int resultIndex = 0;
        public int StrStr(string haystack, string needle)
        {

            if (needle == "")
                return 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                //check if the first char of subString is same as each char of mainString
                if (haystack[i] == needle[0])
                {
                    //already compared first char for main string
                    resultIndex= i;  
                    firstSameCharIndex = i+1;

                    if (needle.Length==1)
                    {//check if the substring only has one char
                        return resultIndex;
                    }
                    //already compared first char for sub string
                    //so , start from 1
                    for (int j = 1; j < needle.Length; )
                    {
                        //if substring is exceed the matched
                        //string in the main string, than invalid
                        if (firstSameCharIndex== haystack.Length)
                        { 
                            return -1;
                        }
                        //if both second char is same, 
                        if (needle[j]==haystack[firstSameCharIndex])
                        {
                            //check if it's the end
                            if (j==needle.Length-1)
                            {
                                return resultIndex;
                            }
                        }
                        else
                        {
                            //find next matched string from rest of main string
                            break;
                        }

                        //compare next
                        j++;
                        firstSameCharIndex++;
                    }
                }
            }
            return -1;
        }
    }
}
