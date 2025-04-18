using System;

namespace CheckDigit
{

    class Program
    {

        public static bool CheckDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')     // if((ch >= 48) && (ch <= 57)) // same logic but use ascii values 
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter one character : ");
            char cVal = char.Parse(Console.ReadLine());

            bool bRet = CheckDigit(cVal);

            if(bRet == true)
            {
                Console.WriteLine(cVal + " is a digit");
            }
            else
            {
                Console.WriteLine(cVal + " is not a digit");
            }
        }
    }
}
