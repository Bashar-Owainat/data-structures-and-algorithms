using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall_13_stack_queue_brackets
{
    public class QueueBrackets
    {
        public Node front;
        public Node rear;
        public int count;

        public QueueBrackets()
        {
            this.front = this.rear = null;
            this.count = 0;

        }

        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(string value)
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
            this.count += 1;
        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("You can't Peek or dequeue on an empty queue!");

            }

            Node temp = this.front;
            this.front = this.front.next;
            temp.next = null;

            if (this.front == null)
            {
                this.rear = null;
            }
            this.count -= 1;
            return temp.value;

        }


        public bool CheckBrackets()
        {
            bool flag = false;
            
            int rightRoundCounter = 0;
            int leftRoundCounter = 0;

            int rightCurlyCounter = 0;
            int leftCurlyCounter = 0;

            int rightSquareCounter = 0;
            int leftSquareCounter = 0;

            while(this.count != 0)
            {
                string DequeuedValue = this.Dequeue();
               
                byte[] ascii = Encoding.ASCII.GetBytes(DequeuedValue);
                
                if (ascii[0] == 40)
                {
                    rightRoundCounter += 1;
                }
                else if(ascii[0] == 41)
                {
                    leftRoundCounter += 1;
                }
                else if(ascii[0] == 123)
                {
                    rightCurlyCounter += 1;
                }
                else if(ascii[0] == 125)
                {
                    leftCurlyCounter += 1;
                }
                else if (ascii[0] == 91)
                {
                    rightSquareCounter += 1;
                }
                else if (ascii[0] == 93)
                {
                    leftSquareCounter += 1;
                }

                if(rightRoundCounter == 0 && leftRoundCounter > rightRoundCounter || 
                    rightCurlyCounter == 0 && leftCurlyCounter > rightCurlyCounter ||
                    rightSquareCounter == 0 && leftSquareCounter > rightSquareCounter)
                {
                    return false;
                }


                if (rightRoundCounter == leftRoundCounter &&
                   rightCurlyCounter ==   leftCurlyCounter &&
                   rightSquareCounter == leftSquareCounter)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }

            return flag;

        }
    }
}
