using System;

namespace AcceptFiveNumbersFromUserAndPrintSummOfGivenNumbers
{
    class Program
    {
        public static int Sumation(int[] Data, int iSize)
        {
            int iSum = 0;
            int iCnt = 0;

            for(iCnt = 0; iCnt < iSize; iCnt++)
            {
                iSum = iSum + Data[iCnt];
            }

            return iSum;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] Arr = new int[5];

            int iRet = 0;
            int iCnt = 0;


            Console.WriteLine("Enter the 5 Element : ");
            

            for( iCnt = 0; iCnt < 5; iCnt++)
            {
                Arr[iCnt] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Print Given Number :");

            for( iCnt = 0; iCnt < 5; iCnt++)
            {
                Console.WriteLine(Arr[iCnt]);
            }

            iRet = Sumation(Arr, 5);

            Console.WriteLine("Summation is : " + iRet);
        }
    }
}
