using System;

namespace AcceptAndPrintFiveNumberUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //int Arr[5];               // in C and C++ Only 
            int[] Arr = new int[5];     // in C#
            int iCnt = 0;

            Console.WriteLine("Enter the Five Numbers :");
            for(iCnt = 0; iCnt < 5; iCnt++)
            {
                Arr[iCnt] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elements of Arry are : ");
            for(iCnt = 0; iCnt < 5; iCnt++)
            {
                Console.WriteLine(Arr[iCnt]);
            }
        }
    }
}
