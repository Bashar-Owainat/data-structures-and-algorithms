using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall10_stack_and_queue
{
    public class MyQueue
    {
        public Node front;
        public Node rear;

        public MyQueue()
        {
            this.front = this.rear = null;
             
        }

        public bool IsEmpty()
        {
            if(front == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (rear == null)
            {
                rear = front = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("You can't Peek or dequeue on an empty queue!");
                
            }

                Node temp = this.front;
                this.front = this.front.next;
                temp.next = null;

            if(this.front == null)
            {
                this.rear = null;
            }
                
            return temp.value;
   
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("You can't Peek or dequeue on an empty queue!");

            }
            else
            {
               return front.value;

            }
        }

       
    }
}
