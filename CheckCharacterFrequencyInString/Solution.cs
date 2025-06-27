using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCharacterFrequencyInString
{
    class Solution
    {
        public void CharFrequency(string input)
        {
            int[] freq = new int[26]; 

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch >= 'a' && ch <= 'z') 
                {
                    int index = ch - 'a';
                    freq[index]++;
                }
            }

            Console.WriteLine("Character Frequencies:");
            for (int i = 0; i < 26; i++)
            {
                if (freq[i] > 0)
                {
                    char ch = (char)(i + 'a');
                    Console.WriteLine(ch + " → " + freq[i]);
                }
            }
        }
    }
}
