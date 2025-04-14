//4
//*  *   *   *   

using System;

namespace PatternPrinting_1
{
    class Program
    {

        public static void Display(int iValue)
        {
            for (int i = 1; i <= iValue; i++)
            {
                Console.Write("*\t");

            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the Number");
            int iNo = int.Parse(Console.ReadLine());

            Display(iNo);
        }
    }
}
