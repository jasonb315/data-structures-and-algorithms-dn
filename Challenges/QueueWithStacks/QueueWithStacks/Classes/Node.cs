using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        public object data { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }

        public Node(object d)
        {
            data = d;
        }
    }
}
