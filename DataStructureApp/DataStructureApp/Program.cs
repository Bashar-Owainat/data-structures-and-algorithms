using DataStructureApp.Chall_12_stack_queue_animal_shelter;
using DataStructureApp.Chall10_stack_and_queue;
using DataStructureApp.Chall10_stack_and_queue_pseudo;
using DataStucture.LinkedList;
using System;
using System.Collections;


namespace DataStructureApp
{
    class Program
    {

        static void Main(string[] args)
        {

            Animal cat1 = new Cat("cat1");
            Animal dog1 = new Dog("dog1");

            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(dog1);

            Console.WriteLine(animalShelter.Dequeue());
            Console.WriteLine(animalShelter.Dequeue());



        }
    }
}
