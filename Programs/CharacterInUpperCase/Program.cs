using System;

namespace CharacterInUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Enter a Character : ");
            char ch = char.Parse(Console.ReadLine());

            char cRet = ToUpperX(ch);

            Console.WriteLine("Character in UpperCase are : {0}",cRet );
        }

        private static char ToUpperX(char ch)
        {

            if ((ch >= 'a') && (ch <= 'z'))
            {
                return (char)(ch - 32);
            }

            return ch;
        }

    }
}
