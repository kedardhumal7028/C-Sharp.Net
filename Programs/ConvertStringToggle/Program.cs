using System;

namespace ConvertStringToggle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();

            string str = StringToggle(input);

            Console.WriteLine("String After Conversion : \n{0}",str);
        }

        private static string StringToggle(string input)
        {
            char[] chars = input.ToCharArray();

            for(int i = 0; i < input.Length; i++)
            {
                if(chars[i] >= 'a' && chars[i] <= 'z')
                {
                    chars[i] = (char)(chars[i] - 32);
                }
                else if(chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)(chars[i] + 32);
                }

            }

            return new string(chars);


        }
    }
}
