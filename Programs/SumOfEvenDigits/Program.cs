using System;

namespace SumOfEvenDigits
{
    class Program
    {
        public static int SumOfEvenDigits(int iNo)
        {

            int iDigit = 0;
            int iSum = 0;

            if(iNo < 0)
            {
                iNo = -iNo;
            }

            while(iNo != 0)
            {
                iDigit = iNo % 10;
                
                if((iDigit % 2) == 0)
                {
                    iSum = iSum + iDigit;
                }

                iNo = iNo / 10;
            }

            return iSum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int iValue = 0;
            int iRet = 0;

            Console.WriteLine("Enter a Number : ");
            iValue = int.Parse(Console.ReadLine());

            iRet = SumOfEvenDigits(iValue);

            Console.WriteLine("Sum of even digits are : " + iRet);
        }
    }
}
