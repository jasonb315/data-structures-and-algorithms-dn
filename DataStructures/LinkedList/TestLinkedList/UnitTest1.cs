using System;
using Xunit;
using LinkedList.Classes;
using System.Collections.Generic;

namespace TestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateAnEmptyList()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            Assert.IsType<SinglyLinkedList>(list);
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertHead()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(5);
            Assert.Equal(5, list.Head.Data);
            
        }

        [Fact]
        public void CanInsertBeforeHead()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(5);
            list.Insert(3);
            Assert.Equal(3, list.Head.Data);
        }

        [Fact]
        public void MultipleAppend()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Append(3);
            list.Append(2);
            list.Append(1);
            Assert.Equal(1, list.Head.Next.Next.Data);

        }

        [Fact]
        public void HeadRemainsFirst()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Append(3);
            list.Append(2);
            list.Append(1);
            Assert.Equal(3, list.Head.Data);
            list.Insert(7);
            Assert.Equal(7, list.Head.Data);
        }

        [Fact]
        public void IncludesReturnsTrueForFoundData()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Append(3);
            list.Append(2);
            list.Append(1);
            Assert.True(list.Includes(3));
            Assert.True(list.Includes(2));
            Assert.True(list.Includes(1));
        }

        [Fact]
        public void IncludesReturnsFalseForNAData()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Append(3);
            list.Append(2);
            list.Append(1);
            Assert.False(list.Includes(7));
            Assert.False(list.Includes(7));
            Assert.False(list.Includes(7));
        }

        [Fact]
        public void ValueCollectionReturnForReadThrough()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Append(7);
            list.Append(7);
            list.Append(7);
            List<int> output = list.ReadThrough();
            Assert.IsType<List<int>>(output);
            foreach (var data in output)
            {
                Assert.Equal(7, data);
            }
        }

        [Fact]
        void InsertBeforeInsertsBefore()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            list.InsertBeforeVal(6, 5);
            List<int> output = list.ReadThrough();
            Assert.Equal(5, output[1]);
        }

        [Fact]
        void InsertBeforeReturnsFalseOnNoHead()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            bool output = list.InsertBeforeVal(1, 1);
            Assert.False(output);
        }

        [Fact]
        void InsertBeforeInsertsBeforeHead()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(4);
            bool output = list.InsertBeforeVal(4, 1);
            List<int> outList = list.ReadThrough();
            Assert.Equal(1, outList[0]);
        }

        [Fact]
        void InsertAfterInsertsAfter()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            list.InsertAfterVal(6, 7);
            List<int> output = list.ReadThrough();
            Assert.Equal(7, output[2]);
        }

        [Fact]
        void InsertAfterReturnsFalseOnNoHead()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            bool output = list.InsertAfterVal(1, 1);
            Assert.False(output);
        }

        [Fact]
        void InsertAfterInsertsAfterSingleNode()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(4);
            bool output = list.InsertAfterVal(4, 1);
            List<int> outList = list.ReadThrough();
            Assert.Equal(1, outList[1]);
        }

        [Fact]
        void KLargerThenN()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            int x = list.KthFromEnd(99);
            Assert.Equal(-1, x);
        }

        [Fact]
        void KEqualsN()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            int x = list.KthFromEnd(2);
            Assert.Equal(8, x);
        }
        
        [Fact]
        void KIsNegative()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(2);
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            list.Insert(10);
            int x = list.KthFromEnd(-2);
            Assert.Equal(-1, x);
        }

        [Fact]
        void ListofSizeOne()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(1);
            int x = list.KthFromEnd(1);
            Assert.Equal(-1, x);
        }

        [Fact]
        void HappyPath()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Insert(2);
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            list.Insert(10);
            int x = list.KthFromEnd(2);
            Assert.Equal(6, x);
        }
    }
}