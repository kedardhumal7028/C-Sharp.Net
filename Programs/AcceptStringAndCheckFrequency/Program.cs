using System;

namespace AcceptStringAndCheckFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String ");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a Single Character to Check Frequency :");
            char ch = char.Parse(Console.ReadLine());

            int iRet = CheckFrequency(input, ch);

            Console.WriteLine("frequency of {0} is {1}", ch,iRet);


        }

        private static int CheckFrequency(string input, char ch)
        {
            int iCnt = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ch)
                {
                    iCnt++;
                }
            }

            return iCnt;
        }
    }
}
