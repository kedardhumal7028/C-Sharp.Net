using System;

namespace Accept_n_number_from_user_and_display_sum_od_even_and_odd_number
{
    class Program
    {
        public static void DisplayEvenOdd(int[] Arr, int iSize)
        {
            int iEvenSum = 0;
            int iOddSum = 0;
            int iCnt;
            for (iCnt = 0; iCnt < iSize; iCnt++)
            {
                if(Arr[iCnt] % 2 == 0)
                {
                    iEvenSum = iEvenSum + Arr[iCnt];
                }
                else
                {
                    iOddSum = iOddSum + Arr[iCnt];
                }
            }

            Console.WriteLine("Sum of Even no is : "+ iEvenSum);
            Console.WriteLine("Sum of Odd no is : "+ iOddSum);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the no of elements : ");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the "+ iLength+ "Numbers :");
            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

             DisplayEvenOdd(ptr, iLength);

        }
    }
}
