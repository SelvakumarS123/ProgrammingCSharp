using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAppCL
{
    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("dog is eating " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
