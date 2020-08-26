using System;
using System.Collections.Generic;
using System.Text;
using Lib_0622_DesignCircularQueue;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0622_DesignCircularQueueTests
    {
        #region MyCircularQueue Class Tests
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new[] { int.MaxValue, 4, int.MinValue }, int.MinValue)]
        [InlineData(new[] { 1, 2, 6, 1, 2 }, 2)]
        public void EnQueueNRearTest(int[] input, int rear)
        {
            var cq = new MyCircularQueue(input.Length);

            foreach (var i in input)
            {
                cq.EnQueue(i);
            }

            cq.DeQueue();
            cq.DeQueue();

            Assert.Equal(rear, cq.Rear());

        }



        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new[] { 5, 3 }, -1)]
        [InlineData(new[] { 5, 3, int.MaxValue, int.MinValue }, int.MinValue)]
        public void DeQueueNFrontTest(int[] input, int front)
        {
            var cq = new MyCircularQueue(input.Length);

            foreach (var i in input)
            {
                cq.EnQueue(i);
            }

            cq.DeQueue();
            cq.DeQueue();
            cq.DeQueue();


            Assert.Equal(front, cq.Front());

        }



        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new[] { 5, 3 }, 2)]
        [InlineData(new[] { 5, 3, int.MaxValue, int.MinValue }, 23)]
        public void DeQueueWhenEmptyTest(int[] input, int dequeueTimes)
        {
            var cq = new MyCircularQueue(input.Length);
            foreach (var i in input)
            {
                cq.EnQueue(i);
            }

            for (int i = 0; i < dequeueTimes; i++)
            {
                cq.DeQueue();
            }


            Assert.False(cq.DeQueue());
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 5, 3 })]
        [InlineData(new[] { 5, 3, int.MaxValue, int.MinValue })]
        public void EnQueueWhenFullTest(int[] input)
        {
            var cq = new MyCircularQueue(input.Length);
            foreach (var i in input)
            {
                cq.EnQueue(i);
            }
            Assert.False(cq.EnQueue(2));
        }



        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 5, 3, 1, int.MaxValue, int.MinValue })]

        public void IsEmptyTest(int[] input)
        {

            var cq = new MyCircularQueue(input.Length);

            foreach (var i in input)
            {
                cq.EnQueue(i);
            }

            for (int i = 0; i < cq.MaxSize; i++)
            {
                cq.DeQueue();
            }

            Assert.True(cq.IsEmpty());
        }





        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        public void IsFullTest(int[] input)
        {
            var cq = new MyCircularQueue(input.Length);

            foreach (var i in input)
            {
                cq.EnQueue(i);
            }

            Assert.True(cq.IsFull());
        }


        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, 4, 5)]
        [InlineData(new[] { 5, int.MaxValue, 3, 231, -3 }, 1, int.MaxValue, -3)]

        public void DeQueueNEnQueueTest(
            int[] enQueueItems, int deQueueTimes,
            int front, int rear)
        {
            var cq = new MyCircularQueue(enQueueItems.Length);

            foreach (var i in enQueueItems)
            {
                cq.EnQueue(i);
            }

            for (int i = 0; i < deQueueTimes; i++)
            {
                cq.DeQueue();
            }

            Assert.True(cq.Front() == front && cq.Rear() == rear);
        }



        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5}, 4, new[] { 6,7,8 }, 5, 8)]
        public void CircularQueueTest(int[] enQueueItems,
            int deQueueTimes, int[] enQueueItemsSecondly,
            int front, int rear)
        {
            var cq = new MyCircularQueue(enQueueItems.Length);
            foreach (var i in enQueueItems)
            {
                cq.EnQueue(i);
            }

            for (int i = 0; i < deQueueTimes; i++)
            {
                cq.DeQueue();
            }

            foreach (var i in enQueueItemsSecondly)
            {
                cq.EnQueue(i);
            }

            Assert.True(cq.Front()==front&&cq.Rear()==rear);
        }

        #endregion
    }
}
