using System;

namespace Accept_n_no_from_user_and_check_occurance_with_the_index
{
    class Program
    {

        public static int CheckOccurance(int[] Arr, int iSize, int iNo)
        {   

            for ( int iCnt = 0; iCnt < iSize; iCnt++)
            {
                if (Arr[iCnt] == iNo)
                {

                    return iCnt;
                }
            }
            return -1;           
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter no of elements");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the " + iLength + " numbers : ");
            for (int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the no to check occurance : ");
            int iValue = int.Parse(Console.ReadLine());

            int bRet = CheckOccurance(ptr, iLength, iValue);

            if (bRet == -1)
            {
                Console.WriteLine(iValue + " Not occured in the array");
                
            }
            else
            {
                Console.WriteLine(iValue + " Occured in the Array at index no is " + bRet);
            }
        }
    }
}
