using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp
{
    public class KaryNode
    {
        public string value;
        public List<KaryNode> child;


        public KaryNode(string value)
        {
            this.value = value;
            this.child = new List<KaryNode>();
        }

        public void AddChild(string value)
        {
            var node = new KaryNode(value);
            this.child.Add(node);
        }

    }
}
