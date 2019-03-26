﻿using System;
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
                tailRef = Head;
                leadRef = Head.Next;
                // this shit fucky
                while (leadRef != null)
                {
                    //leadRef.Data != targetVal &&
                    if (leadRef.Data == targetVal)
                    {
                        Node newNode = new Node(insertVal);
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

        public void InsertAfterVal(int targetVal)
        {

        }
    }
}
