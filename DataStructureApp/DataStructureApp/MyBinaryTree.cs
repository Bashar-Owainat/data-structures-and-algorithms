using System;
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
    }
}
