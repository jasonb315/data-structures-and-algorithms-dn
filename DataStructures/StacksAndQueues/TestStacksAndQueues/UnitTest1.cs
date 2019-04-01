using System;
using Xunit;
using StacksAndQueues.Classes;

namespace TestStacksAndQueues
{
    public class StacksAndQueuesUnitTests
    {
        [Fact]
        public void StackIni()
        {
            Stack stack = new Stack();
            Assert.IsType<Stack>(stack);
        }

        [Fact]
        public void StackPushToEmpty()
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.Equal(5, stack.top.data);
        }

        [Fact]
        public void StackPushMultiple()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(1);
            stack.Push(5);
            Assert.Equal(3, stack.top.prev.prev.data);
        }

        [Fact]
        public void StackPop()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(1);
            stack.Push(5);
            object popped = stack.Pop();
            Assert.Equal(5, popped);
        }

        [Fact]
        public void StackPopMultiple()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(1);
            stack.Push(5);
            object popped = stack.Pop();
            object popped2 = stack.Pop();
            Assert.Equal(1, popped2);
        }

        [Fact]
        public void StackPeek()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(1);
            stack.Push(5);
            object peeked = stack.Peek();
            Assert.Equal(5, peeked);
        }
    }
}


//Can successfully enqueue onto a queue 
//Can successfully enqueue multiple items into a queue
//Can successfully dequeue off of a queue the expected value
//Can successfully peek into a queue, seeing the expected value
//Can successfully empty a queue after multiple dequeues
//Can successfully instantiate an empty queue