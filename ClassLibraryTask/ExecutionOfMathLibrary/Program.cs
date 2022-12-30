using System;
using MathLibrary;
namespace ExecutionOfMathLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1, val2;
            Double.TryParse(Console.ReadLine(), out val1);
            Double.TryParse(Console.ReadLine(), out val2);

            Console.WriteLine("add : {0}", MathClass.Add(ref val1, ref val2));
            Console.WriteLine("subtract : {0}", MathClass.Subtract(ref val1, ref val2));
            Console.WriteLine("multiply : {0}", MathClass.Multiply(ref val1, ref val2));
            Console.WriteLine("divide : {0}", MathClass.Divide(ref val1, ref val2));
        }
    }
}
