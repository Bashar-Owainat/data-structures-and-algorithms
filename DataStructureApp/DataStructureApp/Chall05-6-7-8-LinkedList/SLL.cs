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


        public void Insert( int value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;

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



        public int Length()
        {
            Node temp = head;
            int count = 1;
            while(head.next != null)
            {
                count += 1;
                head = head.next;
            }
            head = temp;
            return count;
        }


        public static SLL ZipList(SLL list1, SLL list2)
        {
            int length1 = list1.Length();
            int length2 = list2.Length();
             int zipListLength = length1 + length2;

            SLL zipList = new SLL();
         
            Node temp1 = list1.head;
            Node temp2 = list2.head;

            int counter = 1;
          

            while (counter <= zipListLength)
            {
                if (counter % 2 != 0)
                {
                  zipList.Append(list1.head.value);
                  
                  list1.head = list1.head.next;
         
                }
                else
                {
                    zipList.Append(list2.head.value);
                    list2.head = list2.head.next;
                   
                }
                counter++;
            }
            list1.head = temp1;
            list2.head = temp2;
            return zipList;
        }

    }
}
