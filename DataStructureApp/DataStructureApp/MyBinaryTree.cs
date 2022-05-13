using DataStructureApp.Chall_13_stack_queue_brackets;
using DataStructureApp.Chall10_stack_and_queue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructureApp
{
    public class MyBinaryTree
    {
       public BinaryTreeNode root { get; set; }

        public List<int> preOrder = new List<int>();
      

        public List<int> TraversePreOrder(BinaryTreeNode root)
        {
           
            Console.WriteLine(root.value);
            preOrder.Add(root.value);

            if (root.leftNode != null)
            {
                TraversePreOrder(root.leftNode);
            }

            if (root.rightNode != null)
            {
                TraversePreOrder(root.rightNode);
            }
            return preOrder;
        }

        public void TraverseInOrder(BinaryTreeNode root)
        {
            if (root.leftNode != null)
            {
                TraversePreOrder(root.leftNode);
            }

            Console.WriteLine(root.value);
            


            if (root.rightNode != null)
            {
                TraversePreOrder(root.rightNode);
            }

            
        }

        public void TraversePostOrder(BinaryTreeNode root)
        {
            if (root.leftNode != null)
            {
                TraversePreOrder(root.leftNode);
            }


            if (root.rightNode != null)
            {
                TraversePreOrder(root.rightNode);
            }

            Console.WriteLine(root.value);
            

        }

        public int FindMax(BinaryTreeNode node)
        {

            if (node == null)
            {
                return int.MinValue;
            }

            int result = node.value;
            int leftResult = FindMax(node.leftNode);
            int rightResult = FindMax(node.rightNode);

            if(leftResult > result)
            {
                result = leftResult;
            }
            if(rightResult > result)
            {
                result = rightResult;
            }
            return result;
        }

        public string BreadthFirst(BinaryTreeNode root)
        {
            Queue<BinaryTreeNode> breadth = new Queue<BinaryTreeNode>();
            breadth.Enqueue(root);
            string result = "";
            while(breadth.Count != 0)
            {
                BinaryTreeNode front = breadth.Dequeue();

                Console.Write(front.value+" ");

                result = result + front.value + " ";
                if (front.leftNode != null)
                {
                    breadth.Enqueue(front.leftNode);
                }

                if(front.rightNode != null)
                {
                    breadth.Enqueue(front.rightNode);
                }
            }
            return result;

        }
    }
}
