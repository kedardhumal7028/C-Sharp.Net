using System;
using System.Collections.Generic;

namespace Maximum_Number_of_Words
{
    class Program
    {
        public static int MaximumWords(List<string> sentenceList)
        {
            int maxWords = 0;

            for (int i = 0; i < sentenceList.Count; i++)
            {
                string currentSentence = sentenceList[i];

                int wordCount = 1;

                for (int j = 0; j < currentSentence.Length; j++)
                {
                    if (currentSentence[j] == ' ')
                    {
                        wordCount++;
                    }
                }

                if (wordCount > maxWords)
                {
                    maxWords = wordCount;
                }
            }

            return maxWords;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of sentences: ");
            int num = int.Parse(Console.ReadLine());

            List<string> sentenceList = new List<string>();

            Console.WriteLine("\nEnter each sentence in a new line:");
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                sentenceList.Add(input);
            }

            int result = MaximumWords(sentenceList);

            Console.WriteLine("\nMaximum number of words in a sentence is: " + result);
        }
    }
}
