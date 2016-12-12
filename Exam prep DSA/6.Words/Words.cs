using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Words
{
    class Words
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var wordCombinations = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                wordCombinations.Add(word);
            }

            int count = 0;

            // Magic
            for (int i = 0; i < text.Length; i++)
            {

            }


            Console.WriteLine(count);
        }
    }
}
