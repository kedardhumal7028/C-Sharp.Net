using System;

namespace Accept_n_numbers_from_user_and_find_minimum_no_in_array
{
        class Program
        {
            public static int Minimum(int[] Arr, int iSize)
            {
                int iMin = Arr[0];
                int iCnt;

                for (iCnt = 0; iCnt < iSize; iCnt++)
                {
                    if (Arr[iCnt] < iMin)
                    {
                        iMin = Arr[iCnt];
                    }
                }

                return iMin;
            }


            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

                Console.WriteLine("Enter the no of Elements");
                int iLength = int.Parse(Console.ReadLine());

                int[] ptr = new int[iLength];

                Console.WriteLine("Enter the " + iLength + " numbers ");
                for (int i = 0; i < iLength; i++)
                {
                    ptr[i] = int.Parse(Console.ReadLine());
                }

                int iRet = Minimum(ptr, iLength);

                Console.WriteLine("Maximum Digit is : " + iRet);

            }
        }
}
