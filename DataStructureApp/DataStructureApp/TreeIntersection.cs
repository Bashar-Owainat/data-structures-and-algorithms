using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp
{
    public class TreeIntersection
    {

        public static void tree_intersection(BinaryTreeNode root1, BinaryTreeNode root2)
        {

            Stack<BinaryTreeNode> s1 = new Stack<BinaryTreeNode>();
            Stack<BinaryTreeNode> s2 = new Stack<BinaryTreeNode>();

            while (true)
            {

                if (root1 != null)
                {
                    s1.Push(root1);
                    root1 = root1.leftNode;
                }



                else if (root2 != null)
                {
                    s2.Push(root2);
                    root2 = root2.leftNode;
                }


                else if (s1.Count > 0 && s2.Count > 0)
                {
                    root1 = s1.Peek();
                    root2 = s2.Peek();


                    if (root1.value == root2.value)
                    {
                        Console.Write(root1.value + " ");
                        s1.Pop();
                        s2.Pop();


                        root1 = root1.rightNode;
                        root2 = root2.rightNode;
                    }

                }

                else if (root1.value < root2.value)
                {

                    s1.Pop();
                    root1 = root1.rightNode;
                    root2 = null;
                }

                else if (root1.value > root2.value)
                {
                    s2.Pop();
                    root2 = root2.rightNode;
                    root1 = null;
                }

                 else
                 {
                        break;
                 }
            }



        }


    }
}
