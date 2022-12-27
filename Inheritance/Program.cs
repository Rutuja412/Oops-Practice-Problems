using System;
using System.Runtime.ConstrainedExecution;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.sounds();
            d1.bark();
        }
    }
}
