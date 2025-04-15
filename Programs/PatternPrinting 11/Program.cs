/*
    Row = 4
    Col = 4

    *   *   *   *
    #   #   #   #
    *   *   *   *
    #   #   #   #

*/

using System;

namespace PatternPrinting_11
{
    class Program
    {
        public static void Display(int iRow, int iCol)
        {
            for (int i = 1; i <= iRow; i++)
            {
                for (int j = 1; j <= iCol; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("#\t");
                    }
                    else
                    {
                        Console.Write("*\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the no of Row : ");
            int iNo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the no of Row : ");
            int iNo2 = int.Parse(Console.ReadLine());

            Display(iNo1, iNo2);
        }
    }
}
