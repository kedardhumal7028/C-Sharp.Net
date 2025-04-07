using System;

namespace CountEvenOddDigit
{
    class Program
    {


        public static void CountEvenOddDigit(int iNo)
        {
            int iDigit = 0;
            int iEvenCnt = 0;
            int iOddCnt = 0;

            if(iNo < 0)
            {
                iNo = -iNo;
            }

            // Optional  code 

            //else if(iNo == 0)
            //{
            //    Console.WriteLine("Number of even digits are : 1");
            //    Console.WriteLine("Number of odd digits are : 0");
            //    return;
            //}

            // Optional  code 

            else if (iNo == 0)
            {
                iEvenCnt++;
            }

            while (iNo != 0)
            {
                iDigit = iNo % 10;
                iNo = iNo / 10;

                if(iDigit % 2 == 0)
                {
                    iEvenCnt++;
                }
                else
                {
                    iOddCnt++;
                }
            }

            Console.WriteLine("Even Digit is : " + iEvenCnt);
            Console.WriteLine("Odd Digit is : " + iOddCnt);

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int iValue = 0;
           

            Console.WriteLine("Enter the number : ");
            iValue = int.Parse(Console.ReadLine());

            CountEvenOddDigit(iValue);


            Console.ReadKey();

           
        }
    }
}
