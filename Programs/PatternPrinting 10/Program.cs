/*
    Row = 4
    Col = 4

    1   1   1   1   
    2   2   2   2   
    3   3   3   3   
    4   4   4   4   
*/


using System;

namespace PatternPrinting_10
{
    class Program
    {
       public static void Display(int iRow, int iCol)
        {
            for(int i = 1; i <= iRow; i++)
            {
                for(int j = 1; j <= iCol; j++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter no of Row : ");
            int iNo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter no of Col : ");
            int iNo2 = int.Parse(Console.ReadLine());

            Display(iNo1, iNo2);

        }
    }
}
