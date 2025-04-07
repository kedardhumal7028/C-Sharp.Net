using System;

namespace SumOfDigit
{
    class Program
    {

        public static int SumOfDigit(int iNo)
        {
            int iDigit = 0;
            int iSum = 0;
            
            if(iNo == 0)
            {
                return 0;
            }

            if(iNo < 0)
            {
                iNo = -iNo;
            }


            while(iNo != 0)
            {
                iDigit = iNo % 10;
                iNo = iNo / 10;

                iSum = iSum + iDigit;
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

            iRet = SumOfDigit(iValue);

            Console.WriteLine("Sum of digit is : " + iRet);

            Console.ReadKey();
            
        }
    }
}
