using System;

namespace Accept_n_No_from_user_and_find_maximum_number_in_array
{
    class Program
    {
        public static int Maximum(int[] Arr, int iSize)
        {
            int iMax = Arr[0];
            int iCnt = 0;

            for(iCnt = 0; iCnt < iSize; iCnt++)
            {
                if(Arr[iCnt] > iMax)
                {
                    iMax = Arr[iCnt];
                }
            }

            return iMax;
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

            int iRet = Maximum(ptr, iLength);

            Console.WriteLine("Maximum Digit is : "+ iRet);

        }
    }
}
