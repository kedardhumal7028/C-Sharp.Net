/*
    Row = 4
    Col = 4

    1   2   3   4
    1   2   3   4
    1   2   3   4
    1   2   3   4

*/

using System;

namespace PatternPrinting_9
{
    class Program
    {
        public static void Display(int iRow, int iCol)
        {
            for(int i = 1; i <= iRow; i++)
            {
                for(int j = 1; j <= iCol; j++)
                {
                    Console.Write(j+"\t");
                }
                Console.WriteLine("\n");
            }
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a Row :");
            int iValue1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Col :");
            int iValue2 = int.Parse(Console.ReadLine());

            Display(iValue1, iValue2);
        }
    }
}
