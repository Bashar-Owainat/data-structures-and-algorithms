using DataStructureApp.Chall10_stack_and_queue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class StackTests 
    { 

        [Fact]
        public void TestPush()
        {
            MyStack stack = new MyStack();
            stack.Push(6);
            Assert.Equal(6, stack.Peek());
        }

        [Fact]
        public void TestMultiplePush()
        {
            MyStack stack = new MyStack();
            stack.Push(6);
            stack.Push(1);
            stack.Push(9);
            stack.Push(62);
            stack.Push(25);

            Assert.Equal(25, stack.Peek());
        }

        [Fact]
        public void TestPop()
        {
            MyStack stack = new MyStack();
            stack.Push(6);
            stack.Push(1);
            stack.Pop();
            Assert.Equal(6, stack.Peek());

        }

        [Fact]
        public void EmptyAStack()
        {
            MyStack stack = new MyStack();
            stack.Push(6);
            stack.Push(1);
            stack.Push(2);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.Null(stack.top);

        }

        [Fact]
        public void InstantiateEmptyStack()
        {
            MyStack stack = new MyStack();
            Assert.Null(stack.top);

        }

        [Fact]
        public void PopException()
        {
            MyStack stack = new MyStack();
            try
            {
                stack.Pop();
            }
            catch(InvalidOperationException e)
            {
                Assert.Equal("Stack is empty! You can't POP or Peek", e.Message);
            }
        }
    }
}
