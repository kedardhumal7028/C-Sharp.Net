using System;

namespace AcceptThenCopyAndConvertToUpperAndPrintOrigianlAndUpperString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();

            Console.WriteLine("Original string : {0}", input);

            string str = UpperString(input);

            Console.WriteLine("After string conversion : {0}",str);
        }

        private static string UpperString(string input)
        {
            char[] chars = input.ToCharArray();
            char[] ch = new char[chars.Length];

            for(int i = 0; i < input.Length; i++)
            {
                if(chars[i] >= 'a' && chars[i] <= 'z')
                {
                    ch[i] = (char)(chars[i] - 32);
                }
                else
                {
                    ch[i] = chars[i];
                }

            }

            return new string(ch);
        }
    }
}
