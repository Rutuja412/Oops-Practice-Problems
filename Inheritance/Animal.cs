using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public void sounds() 
        {
            Console.WriteLine("Animal sound.....");
        }
    }
    public class Dog : Animal
    {
        public void bark() 
        {
            Console.WriteLine("Barking..."); 
        }
    }
}
