using System;

namespace ExtractNumberFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string including digits  : ");
            string input = Console.ReadLine();

            Solution obj = new Solution();
             obj.ExtractNumber(input);
        }
    }

    class Solution
    {
        public void ExtractNumber(string input)
        {

            int temp = 0;
            bool isNumber = false;

            for(int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                int ascii = (int)ch;

                if(ascii >= 48 && ascii <= 57)
                {
                    temp = temp * 10 + (ascii - 48);
                    isNumber = true;
                }
                else
                {
                    if(isNumber == true)
                    {
                        Console.Write("\n" + temp + " ");
                        temp = 0;
                        isNumber = false;
                    }
                }
            }
            if(isNumber == true)
            {
                Console.Write("\n" + temp + " ");
            }
            
            
        }
    }
}
