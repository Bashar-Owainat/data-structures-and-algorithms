using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall_12_stack_queue_animal_shelter
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            // this.name = name;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
