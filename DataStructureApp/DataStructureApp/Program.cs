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
            list.Append(5);
            Console.WriteLine(SLL.ToStringMethod(list));

            Node givenNode = list.head.next.next;
            //list.InsertBefore(givenNode, 9);
            list.InsertAfter(givenNode, 8);

            //list.KthFromEnd(1);

            Console.WriteLine(SLL.ToStringMethod(list));


            //Console.WriteLine(SLL.Includes(list, 2));
            //Console.WriteLine(list.head.value);
        }
    }
}
