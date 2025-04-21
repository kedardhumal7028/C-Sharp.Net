using System;

namespace AcceptStringAndCountCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter aString :");
            string input = Console.ReadLine();

            int iRet = CountSmallCharacter(input);

            Console.WriteLine("Capial Characters in String are {0}", iRet);
        }

        private static int CountSmallCharacter(string Brr)
        {
            int iCnt = 0;

            for (int i = 0; i < Brr.Length; i++)
            {
                if (Brr[i] >= 'A' && Brr[i] <= 'Z')
                {
                    iCnt++;
                }
            }

            return iCnt;
        }
    }
}
