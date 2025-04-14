using System;

namespace PatternPrinting_7
{
    class Program
    {
        public static void Display(int iValue)
        {
            char ch = 'a';

            for (int i = 1; i <= iValue; i++)
            {
                Console.Write(ch + "\t");
                ch++;
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
