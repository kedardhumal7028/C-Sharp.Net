/*
    Row = 6
    Col = 6


    $   *   *   *   *   $
    $   *   *   *   *   $
    $   *   *   *   *   $
    $   *   *   *   *   $             
    $   *   *   *   *   $             
    $   *   *   *   *   $             

*/

using System;

namespace PatternPrinting24
{
    class Program
    {
        public static void Display(int iRow, int iCol)
        {
            for(int i = 1; i <= iRow; i++)
            {
                for(int j = 1; j <= iCol; j++)
                {
                    if((j == 1) || (j == iCol))
                    {
                        Console.Write("$\t");
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

            Console.WriteLine("Enter a no of Row ");
            int iNo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a no of Col ");
            int iNo2 = int.Parse(Console.ReadLine());

            Display(iNo1, iNo2);
        }
    }
}
