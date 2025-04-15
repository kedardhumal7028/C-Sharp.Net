/*
    Row = 4
    Col = 4

    1   $   3   $
    1   $   3   $
    1   $   3   $
    1   $   3   $

*/

using System;

namespace PatternPrinting_14
{
    class Program
    {
        public static void Display(int iRow, int iCol)
        {
            for (int i = 1; i <= iRow; i++)
            {
                for (int j = 1; j <= iCol; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("$\t");
                    }
                    else
                    {
                        Console.Write(j + "\t");                       
                    }
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a Row ");
            int iNo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Col ");
            int iNo2 = int.Parse(Console.ReadLine());

            Display(iNo1, iNo2);
        }
    }
}