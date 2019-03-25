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
            catch (Exception)
            {

                throw;
            }
        }

        public void Includes()
        {
            // bool for key
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Print()
        {
            //read off
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
