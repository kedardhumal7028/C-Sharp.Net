using System;

namespace PatternPrinting_2
{
    class Program
    {
        public static void Display(int iValue)
        {
            for (int i = iValue; i >= 1; i--)
            {
                Console.Write(i + "\t");

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
