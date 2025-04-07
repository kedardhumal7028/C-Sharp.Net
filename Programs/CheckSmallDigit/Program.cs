using System;

namespace CheckSmallDigit
{
    class Program
    {

        public static int SmallDigit(int iNo)
        {
            int iDigit = 0;
            int iSmall = 9;

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

               if(iDigit < iSmall)
                {
                    iSmall = iDigit;
                }

               if(iSmall == 0)
                {
                    break;
                }

                iNo = iNo / 10;
            }

            return iSmall;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int iValue = 0;
            int iRet = 0;

            Console.WriteLine("Enter a number :");
            iValue = int.Parse(Console.ReadLine());

            iRet = SmallDigit(iValue);

            Console.WriteLine("Small Digit is : " + iRet);


        }
    }
}
