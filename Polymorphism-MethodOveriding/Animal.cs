using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_MethodOveriding
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
        public class Dog : Animal //derived class have same method
        {
            public override void eat()
            {
                Console.WriteLine("Eating bread...");
            }
        }

    }
}