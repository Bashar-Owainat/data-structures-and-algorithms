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
        int max = 0;
        int count = 0;
        List<int> stackElements = new List<int>();

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
            stackElements.Add(value);
            count++;
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
                int index = count - 1;
                stackElements.RemoveAt(index);
                count--;

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

        public int GetMax()
        {
            foreach(int element in stackElements)
            {
                if(element > max)
                {
                    max = element;
                }
            }
            return max;
        }

    }
}
