using System;

namespace CheckMaxDigit
{
    class Program
    {

        public static int MaxDigit(int iNo)
        {
            int iDigit = 0;
            int iMax = 0;

            if(iNo < 0)
            {
                iNo = -iNo;
            }


            while(iNo != 0)
            {
                iDigit = iNo % 10;

                if(iDigit > iMax)
                {
                    iMax = iDigit;
                }

                if( iMax == 9)
                {
                    break;
                }

                iNo = iNo / 10;
            }


            return iMax;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int iValue = 0;
            int iRet = 0;

            Console.WriteLine("Enter a number : ");
            iValue = int.Parse(Console.ReadLine());

            iRet = MaxDigit(iValue);

            Console.WriteLine("Max Digit is : " + iRet );
        }
    }
}
