using System;

namespace Check_Character_Assci_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            char ch1 = 'A';
            char ch2 = 'a';
            char ch3 = '0';

            char ch4 = 'Z';
            char ch5 = 'z';
            char ch6 = '9';


            Console.WriteLine("Character representation is {0} and its ASCII value is : {1}", ch1, (int)ch1);
            Console.WriteLine("Character representation is {0} and its ASCII value is : {1}", ch2, (int)ch2);
            Console.WriteLine("Character representation is {0} and its ASCII value is : {1}", ch3, (int)ch3);
            Console.WriteLine();
            Console.WriteLine("Character representation is {0} and its ASCII value is : {1}", ch4, (int)ch4);
            Console.WriteLine("Character representation is {0} and its ASCII value is : {1}", ch5, (int)ch5);
            Console.WriteLine("Character representation is {0} and its ASCII value is : {1}", ch6, (int)ch6);

        }
    }
}
