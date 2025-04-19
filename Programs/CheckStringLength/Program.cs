using System;

namespace CheckStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

            Console.WriteLine("Enter a String : ");
            string input = Console.ReadLine();

            int iRet = stringLength(input);

            Console.WriteLine("Number of Character are : {0} ",iRet);
        }

        private static int stringLength(string Brr)
        {
            int iCnt = 0;

            while (iCnt < Brr.Length)
            {

                iCnt++;
            }

            return iCnt;
        }
    }
}
