using DataStucture.LinkedList;
using System;

namespace DataStructureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            list.Append(6);
            //list.Append(5);
          
            Console.WriteLine(SLL.ToStringMethod(list));

            SLL list2 = new SLL();
            SLL.Insert(list2, 3);
            list2.Append(7);
            //list2.Append(1);
            Console.WriteLine(SLL.ToStringMethod(list2));

            SLL.ZipList(list, list2);
            SLL newList = new SLL();
             newList= SLL.ZipList(list, list2);
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
