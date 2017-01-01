namespace ProblemTypeStrings.Words
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            int total = CountOccurences(word, text);

            for (int i = 1; i < word.Length; i++)
            {
                var prefix = word.Substring(0, i);
                var suffix = word.Substring(i, word.Length - i);

                total += CountOccurences(prefix, text) * CountOccurences(suffix, text);
            }
            Console.WriteLine(total);
        }

        static int CountOccurences(string pattern, string text)
        {
            int count = 0;
            int lastMatchIndex = 0;

            while (lastMatchIndex < text.Length)
            {
                int index = text.IndexOf(pattern, lastMatchIndex);

                if (index < 0)
                {
                    return count;
                }
                count++;
                lastMatchIndex = index + 1;
            }
            return count;
        }
    }
}
