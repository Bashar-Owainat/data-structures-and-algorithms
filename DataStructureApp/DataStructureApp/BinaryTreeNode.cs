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

    }
}
