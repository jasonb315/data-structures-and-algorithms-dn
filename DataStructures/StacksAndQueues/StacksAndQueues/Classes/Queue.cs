using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue
    {
        public Node head { get; set; }
        public Node tail { get; set; }

        public Queue(Node node)
        {
            head = node;
            tail = node;
        }
        //peek
        //enqueue
        //dequeue
    }
}
