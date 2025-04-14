using System;

namespace PatternPrinting_8
{
    class Program
    {
        public static void Display(int iRow, int iCol)
        {
            if (iRow < 0)
            {
                iRow = -iRow;
            }
            if (iCol < 0)
            {
                iCol = -iCol;
            }

            for (int i = 1; i <= iRow; i++)
            {
                for (int j = 1; j <= iCol; j++)
                {
                    Console.Write("*\t");
                   
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the Number of row");
            int iValue1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Number of column");
            int iValue2 = int.Parse(Console.ReadLine());

            Display(iValue1, iValue2);
        }
    }
}
