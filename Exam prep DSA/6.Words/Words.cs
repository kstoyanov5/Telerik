using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _6.Words
{
    class Words
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var wordCombinations = new List<string>();
            int count = new Regex(Regex.Escape(word)).Matches(text).Count;

            for (int i = 1; i < word.Length; i++)
            {
                var preffix = word.Substring(0, i); //preffix
                var suffix = word.Substring(i, word.Length - i); //suffix

                var prefixCount = new Regex(Regex.Escape(preffix)).Matches(text).Count;
                var suffixCount = new Regex(Regex.Escape(suffix)).Matches(text).Count;

                count += prefixCount * suffixCount;
            }
            Console.WriteLine(count);
        }
    }
}
