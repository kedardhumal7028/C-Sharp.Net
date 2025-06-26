using System;

namespace Polymorphism_Method_overloading_OOP_Example
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator obj = new Calculator();

            Console.WriteLine(obj.Add(2, 3));

            Console.WriteLine(obj.Add(2.5, 3.5));
        }
    }
}
