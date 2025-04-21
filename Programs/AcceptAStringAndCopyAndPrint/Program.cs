using System;

namespace AcceptAStringAndCopyAndPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Enter a String :");
            string input = Console.ReadLine();

            string dumy = Copyed(input);

            Console.WriteLine("Copy string is : {0}",dumy);
        }

        private static string Copyed(string input)
        {
            char[] chars1 = input.ToCharArray();
            char[] chars2 = new char[chars1.Length];

            for(int i = 0; i < chars1.Length; i++)
            {
                chars2[i] = chars1[i]; 
            }

            return new string (chars2);
        }
    }
}
