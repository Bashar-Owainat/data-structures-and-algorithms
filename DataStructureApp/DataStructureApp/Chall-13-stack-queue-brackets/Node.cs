using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall_13_stack_queue_brackets
{
    public class Node
    {
        public string value;
        public Node next;

        public Node(string value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
