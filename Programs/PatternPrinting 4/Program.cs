using System;

namespace PatternPrinting_4
{
    class Program
    {
        public static void Display(int iValue)
        {
            for (int i = 1; i <= iValue; i++)
            {
                Console.Write(i + "\t * \t");

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
