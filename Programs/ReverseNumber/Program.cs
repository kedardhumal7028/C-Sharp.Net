using System;

namespace ReverseNumber
{
    class Program
    {

        public static int ReverseNumber(int iNo)
        {
            int iDigit = 0;
            int iRev = 0;

            if(iNo < 0)
            {
                iNo = -iNo;
            }

            while(iNo != 0)
            {
                iDigit = iNo % 10;

                iRev = (iRev * 10) + iDigit;  /// Main Reverse Logic

                iNo = iNo / 10;
            }

            return iRev;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int iValue = 0;
            int iRet = 0;

            Console.WriteLine("Enter the number : ");
            iValue = int.Parse(Console.ReadLine());

            iRet = ReverseNumber(iValue);

            Console.WriteLine("Reverse number is : " + iRet);
        }
    }
}
