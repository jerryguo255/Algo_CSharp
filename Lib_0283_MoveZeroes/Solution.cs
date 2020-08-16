using System;
using System.Linq;

namespace Lib_0283_MoveZeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            var countZeroes = 0;
            bool findZero = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    findZero = true;
                    countZeroes++;
                }
                else
                {
                    if (findZero)
                    {
                        nums[i - countZeroes] = nums[i];
                        nums[i] = 0;
                    }
                   
                   
                }
            }
        }
    }
}
