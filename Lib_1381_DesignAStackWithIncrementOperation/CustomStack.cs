using System;

namespace Lib_1381_DesignAStackWithIncrementOperation
{
    public class CustomStack
    {
        public int MaxSize { get; set; }
        private int count ;
        private readonly int[] _vals;
        /// <summary>
        /// Initializes the object with maxSize which is the maximum number of
        /// elements in the stack or do nothing if the stack reached the maxSize.
        /// </summary>
        /// <param name="maxSize"></param>
        public CustomStack(int maxSize)
        {
            MaxSize = maxSize;
            _vals = new int[maxSize];
        }

        /// <summary>
        /// Adds x to the top of the stack if the stack hasn't reached the maxSize.
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            if (count == MaxSize) return;
            count++;
            _vals[count - 1] = x;

        }

        /// <summary>
        /// Pops and returns the top of stack or -1 if the stack is empty.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (count == 0) return -1;
            count--;
            return _vals[count];
        }

        /// <summary>
        /// void inc(int k, int val) Increments the bottom k elements of the stack by val.
        /// If there are less than k elements in the stack,
        /// just increment all the elements in the stack.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="val"></param>
        public void Increment(int k, int val)
        {
            if (k>MaxSize)
            {
                for (var i = 0; i < MaxSize; i++)
                {
                    _vals[i] += val;
                }
            }
            else {
                for (var i = 0; i < k; i++)
                {
                    _vals[i] += val;
                }
            }

            
        }
    }
}
