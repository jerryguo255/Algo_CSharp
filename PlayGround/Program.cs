using System;
using System.Collections.Generic;
using System.Linq;
using Lib_0622_DesignCircularQueue;


namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] enQueueItems =  {1, 2, 3, 4, 5};
            int deQueueTimes = 4;
            int[] enQueueItemsSecondly =  {6, 7, 8};
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

            Console.WriteLine(cq.Front());
            Console.WriteLine(cq.Rear());

            Console.ReadLine();
        }


    }


}
