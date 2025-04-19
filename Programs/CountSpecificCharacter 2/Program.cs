using System;

namespace CountSpecificCharacter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String :");
            string input = Console.ReadLine();

            int iRet = CountCharacter(input);

            Console.WriteLine("Character of 'a' and 'A' are count of {0}",iRet );
        }

        private static int CountCharacter(string input)
        {
            int iCnt = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'a' || input[i] == 'A')
                {
                     iCnt++;
                }
            }

            return iCnt;
        }
    }
}
