using System;

namespace StringUpperX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String : ");
            string input = Console.ReadLine();

            string str = StringUpperX(input);

            Console.WriteLine("String after conversion is : \n{0}",str);
        }

        private static string StringUpperX(string input)
        {
            char[] chars =  input.ToCharArray();

            for(int i = 0; i < input.Length; i++)
            {
                if(chars[i] >= 'a' &&  chars[i] <= 'z')
                {
                    chars[i] = (char)(chars[i] + 32);
                }
            }

            return new string(chars);
        }
    }
}
