using DataStructureApp.Chall_12_stack_queue_animal_shelter;
using DataStructureApp.Chall10_stack_and_queue;
using DataStructureApp.Chall10_stack_and_queue_pseudo;
using DataStructureApp.Chall_13_stack_queue_brackets;
using DataStucture.LinkedList;
using System;
using System.Collections;
using System.Text;

namespace DataStructureApp
{
    class Program
    {

        static void Main(string[] args)
        {
            QueueBrackets queue = new QueueBrackets();
            queue.Enqueue("[");
            queue.Enqueue("bash");
            queue.Enqueue("[");
           




            Console.WriteLine(queue.CheckBrackets());





        }
    }
}
