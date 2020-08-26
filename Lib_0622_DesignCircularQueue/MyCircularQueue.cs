using System;

namespace Lib_0622_DesignCircularQueue
{
    public class MyCircularQueue
    {
        private int _frontIndex = 0;
        private int _rearIndex = 0;
        public int MaxSize { get; }
        private readonly int[] _vals;
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            MaxSize = k + 1;

            _vals = new int[MaxSize];
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value) // e5 ,e 6 ,e7  M=4    d5,d6 // 11 12  d7
        {
            if (IsFull()) return false;

            if (_rearIndex == MaxSize - 1)//back to zero for circular feature
                _rearIndex = 0;
            else
                _rearIndex++;

            _vals[_rearIndex] = value;

            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty()) return false;

            if (_frontIndex == MaxSize - 1)//back to zero for circular feature
                _frontIndex = 0;
            else
                _frontIndex++;

            _vals[_frontIndex] = 0;

            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty())
                return -1;

            if (_frontIndex+1==MaxSize)
                return _vals[0];

            return _vals[_frontIndex+1];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty())
                return -1;

            return _vals[_rearIndex];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty() => _frontIndex == _rearIndex;

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            if (_rearIndex+1 ==MaxSize)
            {
                if (_frontIndex == 0)
                    return true;
            }
            else if (_rearIndex + 1 == _frontIndex)
                return true;

            return false;
        }
    }
}
