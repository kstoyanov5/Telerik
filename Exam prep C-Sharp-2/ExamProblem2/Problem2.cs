using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;

namespace ExamProblem2
{
    class Problem2
    {
        static string[] symbols = new string[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" };

        static void Main(string[] args)
        {

            var seachWord = Console.ReadLine();

            int numberOfParagraphs = int.Parse(Console.ReadLine());

            var paragraphs = new List<string>();
            var indexes = new List<int>();

            for (int i = 0; i < numberOfParagraphs; i++)
            {
                var currentLineWords = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);

                int relevanceIndex = 0;
                for (int j = 0; j < currentLineWords.Length; j++)
                {
                    string currentWord = currentLineWords[j];
                    if (currentWord.ToLower() == seachWord.ToLower())
                    {
                        relevanceIndex++;
                        currentLineWords[j] = currentWord.ToUpper();
                    }
                }
                paragraphs.Add(string.Join(" ", currentLineWords));
                indexes.Add(relevanceIndex);
            }
            var sorteParagraphs = new List<string>();

            while (sorteParagraphs.Count < paragraphs.Count)
            {
                int maxIndex = 0;
                int maxParagraphIndex = 0;
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (maxIndex < indexes[i])
                    {
                        maxIndex = indexes[i];
                        maxParagraphIndex = i;
                    }
                }
                sorteParagraphs.Add(paragraphs[maxParagraphIndex]);
                indexes[maxParagraphIndex] = -1;
            }

            foreach (var item in sorteParagraphs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
