using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }

        /// <summary>
        ///     Insert a new Node at Head
        /// </summary>
        /// <param name="Val">int new Node val</param>
        public void Insert(int Val)
        {
            //new node to head
            try
            {
                Node newNode = new Node(Val);
                //newNode.Data = Val;

                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    newNode.Next = Head;
                    Head = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        ///     Append new Node to tail
        /// </summary>
        /// <param name="Val">int new Node val</param>
        public void Append(int Val)
        {
            // new node to tail
            try
            {
                Node newNode = new Node(Val);
                // newNode.Data = Val;
                if(Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node currentNode = Head;
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        ///     Search LinkedList for included Node Val by Key
        /// </summary>
        /// <param name="Key">int search val</param>
        /// <returns>bool</returns>
        public bool Includes(int Key)
        {
            // bool for key
            try
            {
                if(Head == null)
                {
                    return false;
                }
                else
                {
                    Node currentNode = Head;
                    while(currentNode != null)
                    {
                        if (currentNode.Data == Key)
                        {
                            return true;
                        }
                        else
                        {
                            currentNode = currentNode.Next;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return false;
        }

        /// <summary>
        ///     ReadsThrough Nodes, collect values, return list
        /// </summary>
        /// <returns>List of Node values</returns>
        public List<int> ReadThrough()
        {
            List<int> outList = new List<int>();

            try
            {

                if(Head == null)
                {
                    Console.WriteLine("Head is null");
                    return null;
                }

                else
                {
                    Node currentNode = Head;
                    while(currentNode != null)
                    {
                        outList.Add(currentNode.Data);
                        currentNode = currentNode.Next;
                    }

                    foreach (var data in outList)
                    {
                        Console.Write(data + " ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return outList;
            
        }

        /// <summary>
        ///     Places a node with a given int before a node with target int
        /// </summary>
        /// <param name="targetVal">int node val to place after</param>
        /// <param name="insertVal">int node cal to be inserted</param>
        /// <returns>bool status of insert</returns>
        public bool InsertBeforeVal(int targetVal, int insertVal)
        {
            Node leadRef = null;
            Node tailRef = null;

            // no nodes
            if (Head == null)
            {
                return false;
            }
            // head node is target
            else if (Head.Data == targetVal)
            {
                Insert(insertVal);
                return true;
            }
            // head node isn't trget, and there's no more to check
            else if (Head.Data != targetVal && Head.Next == null)
            {
                return false;
            }
            // there is a head an a head.next, followed by n nodes
            else
            {
                Node newNode = new Node(insertVal);
                tailRef = Head;
                leadRef = Head.Next;

                while (leadRef != null)
                {
                    if (leadRef.Data == targetVal)
                    {
                        newNode.Next = leadRef;
                        tailRef.Next = newNode;
                        return true;
                    }
                    tailRef = leadRef;
                    leadRef = leadRef.Next;
                }
            }
            return false;
        }

        /// <summary>
        ///     Places a node with a given int after a node with target int
        /// </summary>
        /// <param name="targetVal">int node val to place after</param>
        /// <param name="insertVal">int node cal to be inserted</param>
        /// <returns>bool status of insert</returns>
        public bool InsertAfterVal(int targetVal, int insertVal)
        {
            Node leadRef = null;
            Node tailRef = null;

            if (Head == null)
            {
                return false;
            }
            else if (Head.Data == targetVal)
            {
                Append(insertVal);
                return true;
            }
            else if (Head.Data != targetVal && Head.Next == null)
            {
                return false;
            }
            else
            {
                Node newNode = new Node(insertVal);
                tailRef = Head;
                leadRef = Head.Next;

                while (leadRef != null)
                {
                    if (leadRef.Data == targetVal)
                    {
                        if (leadRef.Next == null)
                        {
                            Append(insertVal);
                            return true;
                        }
                        tailRef = leadRef;
                        leadRef = leadRef.Next;
                        tailRef.Next = newNode;
                        newNode.Next = leadRef;
                        return true;
                    }
                    tailRef = leadRef;
                    leadRef = leadRef.Next;
                }

                return false;
            }

        }

        public int KthFromEnd(int k)
        {
            try
            {
                if (Head == null || k < 0)
                {
                    return -1;
                }
                else
                {
                    Node leadRef = Head;
                    for (int i = 0; i < k; i++)
                    {
                        leadRef = leadRef.Next;
                        //if k > n
                        if (leadRef == null)
                        {
                            return -1;
                        }
                    }
                    // establish distance and move together to end
                    Node tailRef = Head;
                    while(leadRef.Next != null)
                    {
                        leadRef = leadRef.Next;
                        tailRef = tailRef.Next;
                    }
                    return tailRef.Data;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            
        }
    }
}
