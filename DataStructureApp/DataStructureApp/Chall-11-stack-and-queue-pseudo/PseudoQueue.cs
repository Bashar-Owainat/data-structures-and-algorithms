using DataStructureApp.Chall10_stack_and_queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall10_stack_and_queue_pseudo
{
    public class PseudoQueue
    {
        MyStack stack1 = new MyStack();
        MyStack stack2 = new MyStack();

        public void Enqueue(int value)
        {
            while(stack1.top != null)
            {
                stack2.Push(stack1.Pop());
            }

            stack1.Push(value);

            while(stack2.top != null)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public int Dequeue()
        {
            if(stack1.top == null)
            {
                throw new InvalidOperationException("The queue is null ! You can't Dequeue");
            }

            int value = stack1.Peek();
            stack1.Pop();
            return value;
        }

        public int Peek()
        {
            if(stack1.top == null)
            {
                throw new InvalidOperationException("The queue is null. You can't peek!");
            }
            else
            {
                return stack1.top.value;
            }
        }

    }
}
