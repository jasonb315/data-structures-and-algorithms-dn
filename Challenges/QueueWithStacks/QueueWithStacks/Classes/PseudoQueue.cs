using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public static Stack EnQueue = new Stack();
        public static Stack DeQueue = new Stack();

        // flip only on method change between consecutive calls
        public static bool EQing = true;

        public void Enqueue(object data)
        {
            if (EQing is false)
            {
                Flip();
                EQing = true;
            }
            EnQueue.Push(data);
        }

        public static object Dequeue()
        {
            if (EnQueue.top == null && DeQueue.top == null)
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
                returnData = DeQueue.Pop();
                return returnData;
            }
        }

        public static void Flip()
        {
            if (EnQueue.top == null && DeQueue.top == null)
            {
                Console.WriteLine("nothing in queue");
            }

            // flip into DeQueue
            if (EnQueue.top != null && DeQueue.top == null)
            {
                while (EnQueue.top != null)
                {
                    object flipData = EnQueue.Pop();
                    DeQueue.Push(flipData);
                }
            }

            // flip into EnQueue
            if (EnQueue.top == null && DeQueue.top != null)
            {
                while (DeQueue.top != null)
                {
                    object flipData = DeQueue.Pop();
                    EnQueue.Push(flipData);
                }
            }

        }

    }
}
