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
    public class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 8, 4 ,23 ,42 ,16, 15};
           

            Program.PrintArray(arr);
            Program.InsertionSort(arr);
            Program.PrintArray(arr);


        }

        public static int [] InsertionSort (int [] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while( j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = temp;
            }
            return arr;
        }

        public static void PrintArray(int [] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
