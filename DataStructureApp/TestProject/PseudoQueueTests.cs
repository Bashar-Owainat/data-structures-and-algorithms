using DataStructureApp.Chall10_stack_and_queue_pseudo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class PseudoQueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(5);
            
            Assert.NotNull(queue);

        }

        [Fact]
        public void TestDequeue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(5);
            queue.Enqueue(3);

            queue.Dequeue();

            Assert.Equal(3, queue.Peek());

        }

        [Fact]
        public void PeekAnEmptyQueue()
        {
            PseudoQueue queue = new PseudoQueue();

            try
            {
                queue.Peek();

            }
            catch(InvalidOperationException e)
            {
                Assert.Equal("The queue is null. You can't peek!", e.Message);

            }

        }


    }
}
