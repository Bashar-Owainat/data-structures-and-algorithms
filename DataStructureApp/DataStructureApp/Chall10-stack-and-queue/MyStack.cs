using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall10_stack_and_queue
{
    public class MyStack
    {
        public Node top;

        public MyStack()
        {
            this.top = null;
        }

        public bool IsEmpty()
        {
            return top == null;
        }


        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty! You can't POP or Peek");

            }
            else
            {

                Node temp = top;
                top = top.next;
                temp.next = null;

                return temp.value;            
            }
        }


        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty! You can't POP or Peek");
            }
            else
            {
                return top.value;
            }
        }

    }
}
