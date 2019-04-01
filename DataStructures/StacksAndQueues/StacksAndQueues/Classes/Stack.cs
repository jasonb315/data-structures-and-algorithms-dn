using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {
        Node top { get; set; }

        public Stack()
        {
            top = null;
        }

        public void Push(object data)
        {
            Node newNode = new Node(data);

            if (top is Node)
            {
                top.next = newNode;
                newNode.prev = top;
                top = newNode;
            }
            else
            {
                top = newNode;
            }

        }
        public object Pop()
        {
            if (top is Node)
            {
                Node returnNode = top;
                returnNode.prev.next = null;
                returnNode.prev = null;
                return returnNode.data;
            }
            else
            {
                return null;
            }
        }
        public object Peek()
        {
            if (top is Node)
            {
                return top.data;
            }
            else
            {
                return null;
            }
        }
    }
}
