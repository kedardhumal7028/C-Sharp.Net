using System;

namespace CountSpesificCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String :");
            string input = Console.ReadLine();

            int iRet = CountCharacter(input);

            Console.WriteLine("Number of Character of 'a' are {0}", iRet);
        }

        public static int CountCharacter(string Brr)
        {
            int iCnt = 0;

            for(int i = 0; i < Brr.Length; i++)
            {
                if(Brr[i] == 'a')
                {
                    iCnt++;
                }
            }

            return iCnt;
        }
    }
}
