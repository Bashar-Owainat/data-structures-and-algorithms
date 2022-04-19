using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp.Chall_12_stack_queue_animal_shelter
{
    public class Animal
    {
        public string name { get; set; }

        public Animal(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return "Name: "+name;
        }
    }
}
