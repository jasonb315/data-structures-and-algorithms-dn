using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public static Queue EnQueue = new Queue();
        public static Queue DeQueue = new Queue();

        // flip only on method change between consecutive calls
        public static bool EQing = true;

        public void Enqueue(object data)
        {
            if (EQing is false)
            {
                Flip();
                EQing = true;
            }
            EnQueue.Enqueue(data);

        }

        public static object Dequeue()
        {
            if (EnQueue.head == null && DeQueue.head == null)
            {
                Console.WriteLine("nothing in queue");
                return null;
            }
            else
            {
                if (EQing is true)
                {
                    Flip();
                    EQing = false;
                }
                object returnData;
                returnData = DeQueue.Dequeue();
                return returnData;
            }
            
        }

        public static void Flip()
        {
            if (EnQueue.head == null && DeQueue.head == null)
            {
                Console.WriteLine("nothing in queue");
            }

            // flip into DeQueue
            if (EnQueue.head != null && DeQueue.head == null)
            {
                while (EnQueue.head != null)
                {
                    object flipData = EnQueue.Dequeue();
                    DeQueue.Enqueue(flipData);
                }
            }

            // flip into EnQueue
            if (EnQueue.head == null && DeQueue.head != null)
            {
                while (DeQueue.head != null)
                {
                    object flipData = DeQueue.Dequeue();
                    EnQueue.Enqueue(flipData);
                }
            }

        }

    }
}
