using System;

namespace Accept_n_numbers_from_user_and_Display_reverse
{
    class Program
    {
        public static void DisplayReverse(int[] Arr, int iSize)
        {
            for(int i = iSize - 1; i >= 0; i--)
            {
                Console.WriteLine(Arr[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the no of Elements ");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the "+ iLength + " numbers : ");
            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Reverse Array is ");

            DisplayReverse(ptr, iLength);
        }
    }
}
