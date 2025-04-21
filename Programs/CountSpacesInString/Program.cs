using System;

namespace CountSpacesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a string :");
            string input = Console.ReadLine();

            int str = CountSpace(input);

            Console.WriteLine("Count of space is : {0}",str);
        }

        private static int CountSpace(string input)
        {
            char[] chars = input.ToCharArray();
            int iCnt = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if(chars[i] == ' ')
                {
                    iCnt++;
                }
            }

            return iCnt;
        }
    }
}
