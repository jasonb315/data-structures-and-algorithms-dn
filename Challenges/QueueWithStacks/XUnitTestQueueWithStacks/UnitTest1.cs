using QueueWithStacks.Classes;
using System;
using Xunit;

namespace XUnitTestQueueWithStacks
{
    public class UnitTest1
    {
        [Fact]
        public void IsClass()
        {
            PseudoQueue pq = new PseudoQueue();
            Assert.IsType<PseudoQueue>(pq);
        }

        [Fact]
        public void Enqueue()
        {
            PseudoQueue pq = new PseudoQueue();
            pq.Enqueue(100);
            Assert.Equal(100, pq.EnQueue.top.data);
        }

        [Fact]
        public void Dequeue()
        {
            PseudoQueue pq = new PseudoQueue();
            pq.Enqueue(50);
            pq.Dequeue();
            Assert.Null(pq.DeQueue.top);
            Assert.Null(pq.EnQueue.top);
        }

        [Fact]
        public void NullDequeue()
        {
            PseudoQueue pq = new PseudoQueue();
            var x = pq.Dequeue();
            Assert.Null(x);
        }
    }
}