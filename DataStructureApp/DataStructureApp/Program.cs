using DataStructureApp.Chall_12_stack_queue_animal_shelter;
using DataStructureApp.Chall10_stack_and_queue;
using DataStructureApp.Chall10_stack_and_queue_pseudo;
using DataStructureApp.Chall_13_stack_queue_brackets;
using DataStucture.LinkedList;
using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace DataStructureApp
{
    public class Program
    {
    
        static void Main(string[] args)
        {
            //MyBinarySearchTree tree1 = new MyBinarySearchTree();
            //MyBinarySearchTree tree2 = new MyBinarySearchTree();

            //BinaryTreeNode root1 = tree1.root;
            //BinaryTreeNode root2 = tree2.root;

            //root1 = BinaryTreeNode.insert(root1, 5);
            //root1 = BinaryTreeNode.insert(root1, 1);
            //root1 = BinaryTreeNode.insert(root1, 10);
            //root1 = BinaryTreeNode.insert(root1, 0);
            //root1 = BinaryTreeNode.insert(root1, 4);
            //root1 = BinaryTreeNode.insert(root1, 7);
            //root1 = BinaryTreeNode.insert(root1, 9);

            //root2 = BinaryTreeNode.insert(root2, 10);
            //root2 = BinaryTreeNode.insert(root2, 7);
            //root2 = BinaryTreeNode.insert(root2, 20);
            //root2 = BinaryTreeNode.insert(root2, 4);
            //root2 = BinaryTreeNode.insert(root2, 9);



            //TreeIntersection.tree_intersection(root1, root2);

            //Hashtable table1 = new Hashtable();
            //table1.Add(0, "bash");
            //table1.Add(1, "bashar");
            //table1.Add(2, "bash owai");

            //Hashtable table2 = new Hashtable();
            //table1.Add(3, "chirs");
            //table1.Add(4, "christopher");
            //table1.Add(5, "meme");

            //Hashtable result =  JoinTwoTables(table1, table2);

            //foreach(DictionaryEntry entry in result)
            //{
            //    Console.WriteLine(entry.Key + " " + entry.Value);
            //}



            string str = "In a galaxy far far away In a galaxy far far away  galaxy galaxy galaxy galaxy galaxy galaxy";
           Console.WriteLine( MostCommonWord(str));
        }


        public static string MostCommonWord(string str)
        {
            string[] arr = str.Replace(",", "").ToLower().Split(" ");
            Hashtable counts = new Hashtable();

            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (counts.ContainsKey(arr[i]))
                {
                    int value = (int)counts[arr[i]];
                    counts[arr[i]] = value + 1;
                    result = arr[i];
                    
                }

                else
                {
                    counts.Add(arr[i], 1);
                }
            }

            return result;
        }







        public static Hashtable JoinTwoTables(Hashtable table1 , Hashtable table2)
        {


            int Length = table1.Count + table2.Count;

            Hashtable result = new Hashtable();


            for(int i = 0; i < Length; i++)
            {

                  if(i < table1.Count)
                  {

                        result[i] = table1[i];
                  }
                else
                {
                    result[i] = table2[i];

                }
              
                
            }
           


            return result;
        }




      








        public static string RepeatedWord(string str)
        {
            string[] arr = str.Replace(",", "").ToLower().Split(" ");
            IDictionary<string, int> counts = new Dictionary<string, int>();

            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (counts.ContainsKey(arr[i]))
                {
                    int value = counts[arr[i]];
                    counts[arr[i]] = value + 1;
                    result = arr[i];
                    break;
                }

                else
                {
                    counts.Add(arr[i], 1);
                }
            }

            return result;
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
