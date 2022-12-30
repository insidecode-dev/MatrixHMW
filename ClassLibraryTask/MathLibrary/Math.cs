using System;

namespace MathLibrary
{
    public class MathClass
    {
        public static double Add(ref double a, ref double b)
        {
            return a + b;
        }

        public static double Subtract(ref double a, ref double b)
        {
            return a - b;
        }

        public static double Multiply(ref double a, ref double b)
        {
            return a * b;
        }

        public static double Divide(ref double a, ref double b)
        {
            return a / b;
        }
    }
}
