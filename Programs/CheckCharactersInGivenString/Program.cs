using System;

namespace CheckCharactersInGivenString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Enter a String : ");
            string input = Console.ReadLine();

            char[] Arr = input.ToCharArray();

            int iRet = CheckCharactersInGivenString(Arr);

            Console.WriteLine("Number of character are : {0}",iRet);
        }

        private static int CheckCharactersInGivenString(char[] Brr)
        {
            int iCnt = 0, i = 0;

            //while (i < Brr.Length)
            //{
            //    iCnt++;
            //    i++;
            //}

            // Optional loop

            for (i = 0; i < Brr.Length; i++)
            {
                iCnt++;
            }

            return iCnt;
        }
    }
}
