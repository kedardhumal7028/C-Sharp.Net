using System;

namespace Accept_n_numbers_from_user_and_Display_Even_Odd_Count
{
    class Program
    {
        public static void DisplayEvenOdd(int[] Arr, int iSize)
        {
            int iCnt = 0;
            int iEvenCnt = 0;
            int iOddCnt = 0;

            for(iCnt = 0; iCnt < iSize; iCnt++)
            {
                if(Arr[iCnt] % 2 == 0)
                {
                    iEvenCnt++;
                }
                else
                {
                    iOddCnt++;
                }
            }

            Console.WriteLine("Even No of Count is : " + iEvenCnt);
            Console.WriteLine("Odd No of Count is : " + iOddCnt);

            //Console.WriteLine("Odd No of Count is : " + (iSize - iEvenCnt));  // optional
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the no of elements :");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the " + iLength + "numbers : ");

            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            DisplayEvenOdd(ptr, iLength);
        }
    }
}
