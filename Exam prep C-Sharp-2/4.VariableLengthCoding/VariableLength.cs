using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VariableLengthCoding
{
    class VariableLength
    {
        static void Main(string[] args)
        {
            var numbersAsString = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new List<int>();

            StringBuilder encodedString = new StringBuilder();

            foreach (var str in numbersAsString)
            {
                numbers.Add(int.Parse(str));
            }

            foreach (var number in numbers)
            {
                encodedString.Append(Convert.ToString(number, 2).PadLeft(8, '0'));
            }

            var numberOfLines = int.Parse(Console.ReadLine());
            char[] dictionary = new char[numberOfLines + 1];

            for (int i = 0; i < numberOfLines; i++)
            {
                var line = Console.ReadLine();
                char symbol = line[0];
                int index = int.Parse(line.Substring(1));
                dictionary[index] = symbol;
            }

            StringBuilder result = new StringBuilder();

            // Fill result
            int ones = 0;
            foreach (var ch in encodedString.ToString())
            {
                if (ch == '1')
                {
                    ones++;
                }
                else
                {
                    result.Append(dictionary[ones]);
                    ones = 0;
                }
            }
            // If some 1's are left behind, add their letters too.
            if (ones > 0)
            {
                result.Append(dictionary[ones]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
