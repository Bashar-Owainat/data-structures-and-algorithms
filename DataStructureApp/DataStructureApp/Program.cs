using DataStucture.LinkedList;
using System;

namespace DataStructureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL list1 = new SLL();
            SLL list2 = new SLL();

            list1.Append(9);
            list1.Append(6);
            list1.Append(3);

            list2.Append(8);
            list2.Append(4);
            list2.Append(2);

            

            Console.WriteLine(SLL.ToStringMethod(list1));

           
            Console.WriteLine(SLL.ToStringMethod(list2));

            
            SLL newList = new SLL();
             newList= SLL.ZipList(list1, list2);
            Console.WriteLine(SLL.ToStringMethod(newList));

            //Node givenNode = list.head.next.next;
            //list.InsertBefore(givenNode, 9);
            //list.InsertAfter(givenNode, 8);

            //list.KthFromEnd(1);

            //Console.WriteLine(SLL.ToStringMethod(list));


            //Console.WriteLine(SLL.Includes(list, 2));
            //Console.WriteLine(list.head.value);
        }
    }
}
