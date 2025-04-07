using System;

namespace CountOfEvenDigits
{
    class Program
    {
        public static int CountOfEvenDigits(int iNo)
        {
            int iDigit = 0;
            int iCnt = 0;

            if (iNo < 0)
            {
                iNo = -iNo;
            }

            else if(iNo == 0)
            {
                return 1;
            }

            while (iNo != 0)
            {
                iDigit = iNo % 10;

                if ((iDigit % 2) == 0)
                {
                    iCnt++;
                }

                iNo = iNo / 10;

            }

            return iCnt;
        }
    


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int iValue = 0;
            int iRet = 0;

            Console.WriteLine("Enter the Number : ");
            iValue = int.Parse(Console.ReadLine());

            iRet = CountOfEvenDigits(iValue);

            Console.WriteLine("Count of even digit is : " + iRet);

            Console.ReadKey();
        }
    }
}
