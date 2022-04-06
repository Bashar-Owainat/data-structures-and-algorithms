using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStucture.LinkedList
{
    public class SLL
    {
        public Node head;


        public static void Insert(SLL list1, int value)
        {
            Node newNode = new Node(value);
            newNode.next = list1.head;
            list1.head = newNode;

        }

        public static Boolean Includes(SLL list, int value)
        {
            Boolean flag = false;
            Node temp = list.head;
            while (temp.next != null)
            {
                if (temp.value == value)
                {
                    flag = true;
                }

                temp = temp.next;


            }
            if (temp.value == value)
            {
                flag = true;
            }
            return flag;

        }

        public static String ToStringMethod(SLL list)
        {
            String str = "";
            Node temp = list.head;
            while (temp.next != null)
            {
                str = str + "[" + Convert.ToString(temp.value) + "]" + " -> ";
                temp = temp.next;
            }

            str = str + "[" + Convert.ToString(temp.value) + "]" + " -> ";


            str = str + "NUll";
            return str;
        }
        //append at the end
        public void Append(int newValue)
        {
            Node newNode = new Node(newValue);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp;
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void InsertAfter(Node previous, int newValue)
        {
            if (previous == null)
            {
                Console.WriteLine("The previous node cannot be null");
                return;
            }

            // [prev] -> [perv.next]
            //      \   / 
            //       [new]


            Node newNode = new Node(newValue);
            newNode.next = previous.next;
            previous.next = newNode;

        }

        public void InsertBefore(Node givenNode, int newValue)
        {

            if (head == givenNode)
            {
                Node newNode = new(newValue);
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while (head.next != givenNode)
                {

                    head = head.next;
                }

                Node newNode = new Node(newValue);
                newNode.next = head.next;
                head.next = newNode;


            }
        }

        public int KthFromEnd(int k) // k starts from 1
        {
            Node mainPointer = head;
            Node refPointer = head;
            if (k < 1)
            {
                throw new ArgumentException("Invalid input! You cannot enter a number less than 1");
            }
            int counter = 0;
            if (head != null)
            {
                while (counter < k)
                {
                    if (refPointer == null)
                    {
                        throw new IndexOutOfRangeException(k + " is out of the linked list's range! ");
                    }
                    refPointer = refPointer.next;
                    counter++;
                }

                while (refPointer != null)
                {
                    mainPointer = mainPointer.next;
                    refPointer = refPointer.next;
                }
            }

            Console.WriteLine("The value in " + k + " from the end is " + mainPointer.value);
            return mainPointer.value;
        }

    }
}
