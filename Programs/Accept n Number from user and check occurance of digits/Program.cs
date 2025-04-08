using System;

namespace Accept_n_Number_from_user_and_check_occurance_of_digits
{
    class Program
    {

        public static bool CheckOccurance(int[] Arr, int iSize, int iNo)
        {
            int iFrequency = 0;

            for (int iCnt = 0; iCnt < iSize; iCnt++)
            {
                if(Arr[iCnt] == iNo)
                {
                    iFrequency++;
                    // break;   // option
                }
            }

            if(iFrequency == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter no of elements");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the " + iLength +" numbers : ");
            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the no to check occurance : ");
            int iValue = int.Parse(Console.ReadLine());

            bool bRet = CheckOccurance(ptr, iLength, iValue);

            if(bRet == true)
            {
                Console.WriteLine(iValue + " Occured in the Array");
            }
            else
            {
                Console.WriteLine(iValue + " Not occured in the array");
            }
        }
    }
}
