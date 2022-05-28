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
            // Program.MergeSort(arr);
            Program.SortArray(arr, 0, 5);
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


        public static void MergeSort( int [] arr)
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
               
               int rightLength = n - mid;

               int[] right = new int[rightLength+5];

                for(int i = mid;  i < n ;  i++)
                {
                    right[i] = arr[i];
                }

               

                MergeSort(left);

                MergeSort(right);

                Merge(left, right, arr);
            }

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

        public static int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }

            return array;
        }

        public static void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

    }
}
