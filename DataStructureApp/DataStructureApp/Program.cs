﻿using DataStructureApp.Chall_12_stack_queue_animal_shelter;
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
            //QueueBrackets queue = new QueueBrackets();
            //queue.Enqueue("[");
            //queue.Enqueue("bash");
            //queue.Enqueue("[");


            //Stack14 stack = new Stack14();
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());





            //Console.WriteLine(queue.CheckBrackets());

            //MyStack stack = new MyStack();
            //stack.Push(3);
            //stack.Push(5);
            //stack.Pop();
            //stack.Pop();
            //stack.Push(500);
            //stack.Push(50);
            //stack.Push(51);



            //Console.WriteLine(stack.GetMax());




            MyBinarySearchTree Bt = new MyBinarySearchTree();

            Bt.Add(5);
            Bt.Add(10);
            Bt.Add(3);
            Bt.Add(7);
            Bt.Add(70);

            Bt.BreadthFirst(Bt.root);


           // Console.WriteLine("Max value : "+ Bt.FindMax(Bt.root));
            // Bt.TraversePreOrder(Bt.root);
            //Console.WriteLine(Bt.root.value);
            //Console.WriteLine(Bt.Contains(6, Bt.root));


            



        }
    }
}
