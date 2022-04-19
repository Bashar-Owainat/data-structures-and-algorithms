using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall_12_stack_queue_animal_shelter
{
    public class AnimalNode
    {
        public Animal value;
        public AnimalNode next;

        public AnimalNode(Animal value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
