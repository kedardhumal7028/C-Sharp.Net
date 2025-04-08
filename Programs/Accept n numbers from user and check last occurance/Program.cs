using System;

namespace Accept_n_numbers_from_user_and_check_last_occurance
{
    class Program
    {
        public static int CheckLastOccurance(int[] Arr, int iSize, int iValue)
        {
            int i = 0;
            for(i = iSize - 1; i >= 0; i--)
            {
                if(Arr[i] == iValue)
                {
                    break;
                }
            }

            if(i == -1)
            {
                return -1;
            }
            else
            {
                return i;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the no of element : ");
            int iLength = int.Parse(Console.ReadLine());

            int[] ptr = new int[iLength];

            Console.WriteLine("Enter the " + iLength + " numbers :");
            for(int i = 0; i < iLength; i++)
            {
                ptr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the no to check the last occurance : ");
            int iNo = int.Parse(Console.ReadLine());

            int iRet = CheckLastOccurance(ptr, iLength, iNo);

            Console.WriteLine("Last occurance is : " + iRet);
        }
    }
}
