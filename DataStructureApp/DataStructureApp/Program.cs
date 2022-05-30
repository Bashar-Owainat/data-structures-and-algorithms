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
            int[] arr = { 2, 3, 5, 7, 13, 11 };

            Program.PrintArray(arr);
            Program.QuickSort(arr, 0, 5);
           
            Program.PrintArray(arr);

          //  Program.MergeSort(arr);
          //  Program.InsertionSort(arr);


        }


        public static void Swap(int [] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if(arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }

            }
            Swap(arr, right, low + 1);

            return low + 1;
        }

        public static int [] QuickSort(int [] arr, int left, int right)
        {
            if(left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right);

            }

            return arr;
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


        public static int [] MergeSort( int [] arr)
        {
            int n = arr.Length;

            if(n > 1)
            {
                int mid = n / 2;
                int[] left = new int [mid];

                for(int i = 0; i < mid; i ++)
                {
                    left[i] = arr[i];
                }
               
              

               int[] right = new int[n - mid];

                for(int i = mid;  i < n ;  i++)
                {
                    right[i - mid] = arr[i];
                }


                MergeSort(left);

                MergeSort(right);

                Merge(left, right, arr);
            }
            return arr;

        }

        public static void Merge(int [] left, int [] right, int [] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while( i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = right[j];
                    j = j + 1;
                }

                k = k + 1;
            }

            if (i == left.Length)
            {
                for (int count = j; count < right.Length; count++)
                { 
                    arr[k] = right[count];
                }
            }
            else
            {
                for (int count2 = i; count2 < left.Length; count2++)
                {
                    arr[k] = left[count2];
                }
            }
        }

      

    }
}
