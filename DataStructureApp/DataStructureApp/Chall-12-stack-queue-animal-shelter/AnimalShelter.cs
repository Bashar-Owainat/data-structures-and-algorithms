using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall_12_stack_queue_animal_shelter
{
    public class AnimalShelter
    {
        public AnimalNode front;
        public AnimalNode rear;

        public AnimalShelter()
        {
            this.front = this.rear = null;

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

        public void Enqueue(Animal value)
        {
            AnimalNode newNode = new AnimalNode(value);
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

        public string Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("You can't Peek or dequeue on an empty queue!");

            }

            AnimalNode temp = this.front;
            this.front = this.front.next;
            temp.next = null;

            if (this.front == null)
            {
                this.rear = null;
            }

            return temp.value.name;

        }
    }
}
