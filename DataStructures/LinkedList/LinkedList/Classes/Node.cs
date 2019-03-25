using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Next = null;
            Data = val;
        }
    }

    
}
