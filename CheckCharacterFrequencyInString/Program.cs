using System;

namespace CheckCharacterFrequencyInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string input = Console.ReadLine();

            Solution obj = new Solution();

            obj.CharFrequency(input);
        }
    }
}
