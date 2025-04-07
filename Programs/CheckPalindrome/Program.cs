using System;

namespace CheckPalindrome
{
    class Program
    {

        public static bool Palindrome(int iNo)
        {

            int iDigit = 0;
            int iRev = 0;
            int iTemp = iNo;

            if(iNo < 0)
            {
                iNo = -iNo;
            }

            while(iNo != 0)
            {
                iDigit = iNo % 10;
                iRev = (iRev * 10) + iDigit;
                iNo = iNo / 10;

            }

            if(iRev == iTemp)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int iValue = 0;
            bool iRet;

            Console.WriteLine("Enter the number : ");
            iValue = int.Parse(Console.ReadLine());

            iRet = Palindrome(iValue);
            if (iRet == true)
            {
                Console.WriteLine("The Number is Palindrome");
            }
            else
            {
                Console.WriteLine("The Nuber is not Palindrome");
            }
        }
    }
}
