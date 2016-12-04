using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.MagicWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var words = new List<string>();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                var word = words[i];
                var newIndex = word.Length % (n + 1);

                words.Insert(newIndex, word);
                if (newIndex < i)
                {
                    words.RemoveAt(i+1);
                }
                else
                {
                    words.RemoveAt(i);
                }
            }

            var maxLength = words.Max(x => x.Length);

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        builder.Append(word[i]);
                    }
                }
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
