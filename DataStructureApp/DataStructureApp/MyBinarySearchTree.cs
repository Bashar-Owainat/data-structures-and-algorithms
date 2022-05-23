using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp
{
    public class MyBinarySearchTree : MyBinaryTree
    {
        public void Add(int value)
        {
            BinaryTreeNode before = null;
            BinaryTreeNode after = this.root;

            while (after != null)
            {
                before = after;
                if (value < after.value)
                {
                    after = after.leftNode;
                }
                else if (value > after.value)
                {
                    after = after.rightNode;
                }

            }

            BinaryTreeNode newNode = new BinaryTreeNode(value);



            if (this.root == null)
            {
                this.root = newNode;

            }
            else
            {
                if (value < before.value)
                {
                    before.leftNode = newNode;

                }
                else
                {
                    before.rightNode = newNode;
                }
            }

        }




        public static int CountChildren(BinaryTreeNode root)
        {

            int count = 0;

            if (root.leftNode != null)
            {
                CountChildren(root.leftNode);
            }
            else
            {
                count += 1;
            }


            if (root.rightNode != null)
            {
                CountChildren(root.rightNode);
            }
            else
            {
                count += 1;
            }

            return count;
        }

        public static bool CompareTrees(MyBinaryTree tree1, MyBinaryTree tree2)
        {

            int treeOneConut = CountChildren(tree1.root);
            int treeTwoConut = CountChildren(tree2.root);

            if (treeOneConut == treeTwoConut)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        public bool Contains(int value, BinaryTreeNode root)
        {
            
            if (root == null )
            {
                return false;
            }
            if(root.value == value)
            {
                return true;
            }
            if (value < root.value)
                return Contains( value, root.leftNode);
            else
            {
                return Contains(value, root.rightNode);

            }

        }
    }
}
