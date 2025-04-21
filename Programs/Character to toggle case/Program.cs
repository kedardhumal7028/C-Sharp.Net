using System;

namespace Character_to_toggle_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enetr a character : ");
            char ch = char.Parse(Console.ReadLine());

            char iRet = ToToggle(ch);

            Console.WriteLine("Character in Lower case is {0}", iRet);
        }

        private static char ToToggle(char ch)
        {
            if (ch >= 'A' && ch <= 'Z')
            {
                return (char)(ch + 32);
            }

            else if (ch >= 'a' && ch <= 'z')
            {
                return (char)(ch - 32);
            }

            else
            {
                return ch;
            }

            throw new NotImplementedException();
        }
    }
}
