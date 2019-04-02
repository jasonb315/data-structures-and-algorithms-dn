using StacksAndQueues.Classes;
using System;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack EnQueue = new Stack();
        public Stack DeQueue = new Stack();

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

        public object Dequeue()
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

        public void Flip()
        {
            if (EnQueue.top == null && DeQueue.top == null)
            {
                Console.WriteLine("nothing in queue");
            }

            // flip into DeQueue
            else if(EnQueue.top != null && DeQueue.top == null)
            {
                while (EnQueue.top != null)
                {
                    DeQueue.Push(EnQueue.Pop());
                }
            }

            // flip into EnQueue
            else if (EnQueue.top == null && DeQueue.top != null)
            {
                while (DeQueue.top != null)
                {
                    EnQueue.Push(DeQueue.Pop());
                }
            }

        }

    }
}
