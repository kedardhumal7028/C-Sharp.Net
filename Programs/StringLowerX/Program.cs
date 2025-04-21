using System;

namespace StringLowerX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String ");
            string input = Console.ReadLine();

            string str = StringLowerX(input);

            Console.WriteLine("String After Conversion is : \n{0}",str);

        }

        private static string StringLowerX(string input)
        {
            char[] chars = input.ToCharArray();
            
           for(int i = 0; i < input.Length; i++)
            {
                if(chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)(chars[i] + 32);
                }
            }

            return new string(chars);
        }
    }
}
