using System;

namespace Print_Ascii_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("ASCII TABLE");
            Console.WriteLine();

            Console.WriteLine("Character\t Decimal\t Hex\t Octal");
            for(int i = 0; i<= 127; i++)
            {
                char ch = (char)i;
                Console.WriteLine("{0}\t\t{1}\t\t{2:X}\t{3}",char.IsControl(ch) ? ' ' : ch, i, i, Convert.ToString(i, 8));
            }
        }
    }
}
