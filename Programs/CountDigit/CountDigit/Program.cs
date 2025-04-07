using System;

namespace CountDigit
{
    class Program
    {

        public int CountDigit(int iNo) // public static int CountDigit(int iNo) - static naslya mule khali obj banvava lagla 
        {

            int iDigit = 0;
            int iCnt = 0;

            if(iNo == 0)
            {
                return 1;
            }

            if (iNo < 0)
            {
                iNo = -iNo;
            }

            while (iNo != 0)
            {
                iDigit = iNo % 10;
                iNo = iNo / 10;
                iCnt++;
            }

            return iCnt;

            // return iNo.ToString().Length;   /// he option length method use karun aapan direct length kadu shakto 
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!\n");

            int iValue = 0;
            int iRet = 0;

            Program obj = new Program();  ///jar CountDigit Function static nasel tr tyala call karnyasathi Obj banvava lagto ani to banvla ki obj.CountDigit(iValue); asa call karava lagto 


            Console.WriteLine("Enter a Number :");
            iValue = int.Parse(Console.ReadLine());

            iRet = obj.CountDigit(iValue); // function call 

            Console.WriteLine("\nDigits are : " + iRet);

            Console.ReadKey();
        }
    }
}
