using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node head { get; set; }
        public Node tail { get; set; }

        public Queue()
        {
            head = null;
            tail = null;
        }

        /// <summary>
        ///     Look at value head of queue
        /// </summary>
        /// <returns>Queue.head.data</returns>
        public object Peek()
        {
            // protect from null pointer exception
            if (head is Node)
            {
                return head.data;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        ///     Attaches object inout to node and appends to tail, updates tail.
        /// </summary>
        /// <param name="data">data for Node to Enqueue</param>
        public void Enqueue(object data)
        {
            Node newNode = new Node(data);
            
            // queue with at least one
            if (tail is Node)
            {
                newNode.next = tail;
                tail.prev = newNode;
                tail = newNode;
            }
            // if empty queue
            else
            {
                head = newNode;
                tail = newNode;
            }
        }

        /// <summary>
        ///     Returns the head Nodes object
        /// </summary>
        /// <returns>Head Node object</returns>
        public object Dequeue()
        {
            if (head is Node)
            {
                // get object to return data from
                Node returnNode = head;

                // manipulate queue:

                // if one Node in Queue
                if (head.prev is null)
                {
                    head = null;
                }
                // more than one Node in Queue
                else
                {
                    // relocate head behind returnNode
                    head = head.prev;
                    // sever ties to returnNode for garbage collection
                    returnNode.prev = null;
                    head.next = null;
                }

                // return Enqueued object from Node
                return returnNode.data;
            }
            // head is null
            else
            {
                return null;
            }
        }
    }
}
