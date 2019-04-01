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

        [Fact]
        public void QueueIni()
        {
            Queue queue = new Queue();
            Assert.IsType<Queue>(queue);
        }

        [Fact]
        public void QueueEnqueueToEmpty()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.head.data);
        }

        [Fact]
        public void QueueMultipleEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(5);
            Assert.Equal(5, queue.head.prev.prev.data);
        }

        [Fact]
        public void QueueDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(5);
            object dequeued = queue.Dequeue();
            Assert.Equal(3, dequeued);
        }

        [Fact]
        public void QueueMultipleDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(5);
            object dequeued = queue.Dequeue();
            object dequeued2 = queue.Dequeue();
            Assert.Equal(1, dequeued2);
        }

        [Fact]
        public void QueuePeek()
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(5);
            object dequeued = queue.Peek();
            Assert.Equal(3, dequeued);
        }
    }
}