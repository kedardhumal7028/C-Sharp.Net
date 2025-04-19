using System;

namespace AcceptStringAndCountSmallCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter aString :");
            string input = Console.ReadLine();

            int iRet = CountSmallCharacter(input);

            Console.WriteLine("Small Characters in String are {0}",iRet);
        }

        private static int CountSmallCharacter(string Brr)
        {
            int iCnt = 0;

            for(int i = 0; i < Brr.Length; i++)
            {
                if(Brr[i] >= 'a' && Brr[i] <= 'z')
                {
                    iCnt++;
                }
            }

            return iCnt;
        }
    }
}
