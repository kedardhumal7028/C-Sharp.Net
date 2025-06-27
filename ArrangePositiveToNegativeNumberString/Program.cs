using System;

namespace ArrangePositiveToNegativeNumberString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a comma-separated number string: ");   // { 2 , -1 , 4 , -3 , 5 , -2 , 1 , -4 , 3 , -5 }
            string input = Console.ReadLine();

            Solution obj = new Solution();

            obj.ArrangeNumberString(input);
        }
    }

    class Solution
    {
        public void ArrangeNumberString(string input)
        {
            string[] parts = input.Split(',');
            int n = parts.Length;
            int[] numbers = new int[n];
            

            for(int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            int[] result = new int[n];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= 0)
                {
                    result[index++] = numbers[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 0)
                {
                    result[index++] = numbers[i];
                }
            }

            Array.Sort(result);

            Console.WriteLine("Arranged numbers:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}
