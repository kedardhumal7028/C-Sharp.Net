using System;

namespace Upper_Character_to_lower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Enetr a character : ");
            char ch = char.Parse(Console.ReadLine());

            char iRet = ToLower(ch);

            Console.WriteLine("Character in Lower case is {0}",iRet);
        }

        private static char ToLower(char ch)
        {
            if(ch >= 'A' && ch <= 'Z')
            {
                return (char)(ch + 32);
            }
            else
            {
                return ch;
            }

            throw new NotImplementedException();
        }
    }
}
