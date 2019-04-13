using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node top { get; set; }

        public Stack()
        {
            top = null;
        }

        /// <summary>
        ///     Add Node w/data to top of stack
        /// </summary>
        /// <param name="data">data object</param>
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

        /// <summary>
        ///     Remove and return top of stack
        /// </summary>
        /// <returns>top data object</returns>
        public object Pop()
        {
            if (top is Node)
            {
                Node returnNode = top;
                top = returnNode.prev;
                // sever for garbage collection
                //returnNode.prev.next = null;
                returnNode.prev = null;
                // return top nodes data object
                return returnNode.data;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Look at the top nodes data without mutating stack
        /// </summary>
        /// <returns>top nodes data</returns>
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
