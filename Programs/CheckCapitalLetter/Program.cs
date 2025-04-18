using System;

namespace CheckCapitalLetter
{
    class Program
    {

        public static bool CheckCapitalLetter(char ch)
        {
            if(ch >= 'A' && ch <= 'Z')   //if(ch >= 65 && ch <= 90) 
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

            Console.WriteLine("Enter a Character : ");
            char cValue = char.Parse(Console.ReadLine());

            bool bRet = CheckCapitalLetter(cValue);

            if(bRet == true)
            {
                Console.WriteLine(cValue + " is capital Letter");
            }
            else
            {
                Console.WriteLine(cValue + " is not Capital Letter");
            }
        }
    }
}
