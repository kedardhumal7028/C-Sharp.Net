using System;

namespace CheckCharacterPresentOrNotInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String ");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a Single Character to Check Present or Not :");
            char ch = char.Parse(Console.ReadLine());

            bool iRet = CheckPresent(input, ch);

            if(iRet == true)
            {
                Console.WriteLine("Character are Present in String");
            }
            else
            {
                Console.WriteLine("Character are not Present in String");
            }


        }

        private static bool CheckPresent(string input, char ch)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ch)
                {
                    return true;
                    
                }
               
            }
            return false;
        }
    }
}
