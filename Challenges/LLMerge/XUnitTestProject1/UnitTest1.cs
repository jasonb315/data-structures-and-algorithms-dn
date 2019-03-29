using System;
using Xunit;
using LinkedList.Classes;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPath()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            list1.Append(1);
            list1.Append(2);
            list1.Append(3);
            list1.Append(4);
            list1.Append(5);

            SinglyLinkedList list2 = new SinglyLinkedList();
            list2.Append(10);
            list2.Append(20);
            list2.Append(30);
            list2.Append(40);
            list2.Append(50);

            SinglyLinkedList list3 = new SinglyLinkedList();
            list3.Head = LLMerge.Program.LLMerge(list1, list2);

            List<int> nodeVals = new List<int>();
            Node currentNode = list3.Head;
            while (currentNode != null)
            {
                nodeVals.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }
            int[] nodeValList = nodeVals.ToArray();
            int[] nodeExpected = new int[] { 1, 10, 2, 20, 3, 30, 4, 40, 5, 50 };
            Assert.Equal(nodeExpected, nodeValList);
        }
        [Fact]
        public void ANullBFull()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            SinglyLinkedList list2 = new SinglyLinkedList();
            list2.Append(10);
            list2.Append(20);
            list2.Append(30);
            list2.Append(40);
            list2.Append(50);

            SinglyLinkedList list3 = new SinglyLinkedList();
            list3.Head = LLMerge.Program.LLMerge(list1, list2);

            List<int> nodeVals = new List<int>();
            Node currentNode = list3.Head;
            while (currentNode != null)
            {
                nodeVals.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }
            int[] nodeValList = nodeVals.ToArray();
            int[] nodeExpected = new int[] { 10,20,30,40,50 };
            Assert.Equal(nodeExpected, nodeValList);

        }

        [Fact]
        public void AFullBNull()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            SinglyLinkedList list2 = new SinglyLinkedList();
            list1.Append(1);
            list1.Append(2);
            list1.Append(3);
            list1.Append(4);
            list1.Append(5);

            SinglyLinkedList list3 = new SinglyLinkedList();
            list3.Head = LLMerge.Program.LLMerge(list1, list2);

            List<int> nodeVals = new List<int>();
            Node currentNode = list3.Head;
            while (currentNode != null)
            {
                nodeVals.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }
            int[] nodeValList = nodeVals.ToArray();
            int[] nodeExpected = new int[] { 1,2,3,4,5 };
            Assert.Equal(nodeExpected, nodeValList);
        }

        [Fact]
        public void ANullBNull()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            SinglyLinkedList list2 = new SinglyLinkedList();
            
            Node nullNode = LLMerge.Program.LLMerge(list1, list2);
            Assert.Null(nullNode);
        }
    }
}