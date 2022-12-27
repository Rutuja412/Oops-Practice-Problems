using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_MethodOverloading
{
    public class Calculation
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
