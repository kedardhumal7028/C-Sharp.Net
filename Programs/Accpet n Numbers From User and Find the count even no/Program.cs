using System;

namespace Accpet_n_Numbers_From_User_and_Find_the_count_even_no
{
    class Program
    {

        public static int Average(int[] Arr, int iSize)
        {
            int iCnt = 0;
            int iEvenCnt = 0;

            for (iCnt = 0; iCnt < iSize; iCnt++)
            {
                if(Arr[iCnt] % 2 == 0)
                {
                     iEvenCnt++;
                }
            }

            return iEvenCnt;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the number of elements");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the " + iLength + " Numbers");
            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            int iRet = Average(ptr, iLength);

            Console.WriteLine("Count of Even No is : " + iRet);
        }
    }
}
