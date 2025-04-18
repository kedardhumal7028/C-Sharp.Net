using System;

namespace CheckSmallLetter
{
    class Program
    {
        public static bool CheckSmallLetter(char chVal)
        {
            if(chVal >= 'a' && chVal <= 'z')   // if(chVal >= 97 && chVal <= 122)  // same logic but use character or ascii value
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
            char ch = char.Parse(Console.ReadLine());

            bool bRet = CheckSmallLetter(ch);

            if(bRet == true)
            {
                Console.WriteLine(ch + " is a Small Letter");
            }
            else
            {
                Console.WriteLine(ch + " not a small Letter");
            }
        }
    }
}
