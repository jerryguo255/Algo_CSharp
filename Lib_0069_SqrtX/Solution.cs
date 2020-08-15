using System;

namespace Lib_0069_SqrtX
{
    public class Solution
    {
        
        public int MySqrt(int x)
        {
            if (x <= 1)
                return x;
            //Binary Search
            int left = 1;
            int right = x;
            int mid = right / 2;
            while (x / mid != mid )
            {
                if (x / mid < mid) right = mid;
                else left = mid;

                if (right - left <=1)
                {
                    mid = left;
                    break;
                }
                mid = left +((right - left) / 2);
            }
            return mid;
        }

    }
}
