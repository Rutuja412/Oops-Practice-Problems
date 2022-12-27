using System;

namespace Polymorphism_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(Calculation.add(12, 14));
                Console.WriteLine(Calculation.add(12, 14, 25));
            }
        }
    }
}
