using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp
{
    public class KaryTree
    {
        public KaryNode root;
        //public KaryTree()
        //{
        //    this.root = null;
        //}

        public void FizzBuzz(KaryTree tree)
        {
            
            Queue<KaryNode> queue = new Queue<KaryNode>();
            queue.Enqueue(tree.root);

            while (queue.Count != 0)
            {
                KaryNode front = queue.Dequeue();

                if (Convert.ToInt32(front.value) % 5 == 0 && Convert.ToInt32(front.value) % 3 == 0)
                {
                    
                    front.value = "FizzBuzz";
                    Console.WriteLine(front.value);

                }

                else if (Convert.ToInt32(front.value) % 5 == 0)
                {
                    
                    front.value = "Buzz";
                    Console.WriteLine(front.value);


                }
                else if (Convert.ToInt32(front.value) % 3 == 0)
                {

                    
                    front.value = "Fuzz";
                    Console.WriteLine(front.value);


                }
                else
                {
                    Console.WriteLine(front.value);

                }

                foreach(KaryNode child in front.child)
                {
                    queue.Enqueue(child);
                }



            }
        }
    }
}
