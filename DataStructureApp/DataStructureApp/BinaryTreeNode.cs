using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode leftNode { get; set; }
        public BinaryTreeNode rightNode { get; set; }
        public int value;

        public BinaryTreeNode(int item)
        {
            value = item;
            leftNode = null;
            rightNode = null;
        }

        public static BinaryTreeNode insert(BinaryTreeNode node, int key)
        {

            if (node == null)
            {
                return new BinaryTreeNode(key);
            }


            if (key < node.value)
            {
                node.leftNode = insert(node.leftNode, key);
            }
            else if (key > node.value)
            {
                node.rightNode = insert(node.rightNode, key);
            }


            return node;
        }

    }
}
