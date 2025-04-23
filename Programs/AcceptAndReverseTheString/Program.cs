using System;

namespace AcceptAndReverseTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String : ");
            string input = Console.ReadLine();

            Console.WriteLine("Original String : {0}",input);

            string str = ReverseString(input);

            Console.WriteLine("Reverse String : {0}",str);

        }

        public static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            char[] ch = new char[chars.Length];

            int count = chars.Length - 1;
            int j = 0;

            for(int i = count; i >= 0; i--)
            {
                ch[i] = chars[j];
                j++;
            }

            return new string(ch);

        }
    }
}
