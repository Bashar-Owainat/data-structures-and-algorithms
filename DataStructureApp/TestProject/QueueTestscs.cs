using DataStructureApp.Chall10_stack_and_queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class QueueTestscs
    {
        [Fact]
        public void TestEnqueue()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(5);

            Assert.Equal(5, queue.rear.value);
        }

        [Fact]
        public void TestMultipleEnqueue()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(8);


            Assert.Equal(8, queue.rear.value);
        }

        [Fact]
        public void TestDequeue()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Dequeue();


            Assert.Equal(3, queue.rear.value);
        }

        [Fact]
        public void TestPeek()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(5);
            queue.Enqueue(3);
            
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void EmptyAQueue()
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Dequeue();

            Assert.Null(queue.front);
        }


        [Fact]
        public void IstantiateEmptyAQueue()
        {
            MyQueue queue = new MyQueue();
            Assert.Null(queue.front);
        }

        

        [Fact]
        public void PeekOrDequeueException()
        {
            MyQueue queue = new MyQueue();
            try
            {
                queue.Dequeue();
            }
            catch(InvalidOperationException e)
            {

                Assert.Equal("You can't Peek or dequeue on an empty queue!", e.Message);
            }
        }

    }
}
