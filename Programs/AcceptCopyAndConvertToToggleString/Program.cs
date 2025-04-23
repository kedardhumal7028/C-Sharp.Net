using System;

namespace AcceptCopyAndConvertToToggleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a String :");
            string input = Console.ReadLine();

            Console.WriteLine("Original String : {0}",input);

            string str = StringToggle(input);

            Console.WriteLine("After string conversion : {0}",str);
        }

        private static string StringToggle(string input)
        {
            char[] chars = input.ToCharArray();
            char[] ch = new char[chars.Length];

            for(int i = 0; i < input.Length; i++)
            {
                if(chars[i] >= 'a' && chars[i] <= 'z')
                {
                    ch[i] = (char)(chars[i] - 32);
                }
                else if(chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    ch[i] = (char)(chars[i] + 32);
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
