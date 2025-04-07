using System;

namespace Accept_the_no_from_user_and_return_the_average
{
    class Program
    {
        public static float Average(int[] Arr, int iSize)
        {
            int iSum = 0;

            for(int iCnt = 0; iCnt < iSize; iCnt++)
            {
                 iSum = iSum + Arr[iCnt];
            }

            return (float)iSum / iSize;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the no of Elements :");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the " + iLength + " numbers :");
            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            float iRet = Average(ptr, iLength);

            Console.WriteLine("Average is : " + iRet );
        }
    }
}
