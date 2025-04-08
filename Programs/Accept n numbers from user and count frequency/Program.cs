using System;

namespace Accept_n_numbers_from_user_and_count_frequency
{
    class Program
    {

        public static int CheckFrequency(int[] Arr, int iSize, int iNo)
        {
            int iFrequency = 0;

            for (int iCnt = 0; iCnt < iSize; iCnt++)
            {
                if(Arr[iCnt] == iNo)
                {
                     iFrequency++;
                }
            }

            return iFrequency;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the no of elements : ");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the " + iLength + " nubers : ");
            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number to check the Frequency : ");
            int iValue = int.Parse(Console.ReadLine());

            int iRet = CheckFrequency(ptr, iLength, iValue);

            Console.WriteLine("frequency of " + iValue + " is " + iRet);
        }
    }
}
