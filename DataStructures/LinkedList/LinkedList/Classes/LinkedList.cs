using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;


namespace LinkedList.Classes
{
    class LinkedList
    {
        public Node Head { get; set; }

        public void Insert(int Val)
        {
            //new node to head
            try
            {
                Node newNode = new Node();
                newNode.Data = Val;

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

        public void Append(int Val)
        {
            // new node to tail
            try
            {
                Node newNode = new Node();
                newNode.Data = Val;
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

        public bool Includes(int Key)
        {
            // bool for key
            try
            {
                if(Head != null)
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

        public void Print()
        {
            //read off
            try
            {
                List<int> outList = new List<int>();

                if(Head == null)
                {
                    Console.WriteLine("Head is null");
                }
                else
                {
                    Node currentNode = Head;
                    while(currentNode != null)
                    {
                        outList.Add(currentNode.Data);
                        currentNode = currentNode.Next;
                    }
                }

                foreach (var data in outList)
                {
                    Console.Write(data + " ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
