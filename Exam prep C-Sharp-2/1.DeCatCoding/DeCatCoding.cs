using System;
using System.Numerics;
using System.Text;
using System.Collections.Generic;

namespace _1.DeCatCoding
{
    class DeCatCoding
    {
        static List<string> stadigits = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var digits = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u" };

            BigInteger result = 0;
            var numeralSystem = 21;

            List<string> finalResult = new List<string>();
            StringBuilder builder = new StringBuilder();

            string[] splits = input.Split(' ');

            for (int i = 0; i < splits.Length; i++)
            {
                for (int j = 0; j < splits[i].Length; j++)
                {
                    var currentNum = splits[i].Substring(j, 1);
                    var decimalValue = digits.IndexOf(currentNum);

                    result *= numeralSystem;
                    result += decimalValue;
                }
                ConvertFromDecimal(result, 26);
                result = 0;
            }       
        }

        static void ConvertFromDecimal(BigInteger number, int baseTo)
        {
            List<BigInteger> result = new List<BigInteger>();
            if (baseTo > 10)
            {
                while (number > 0)
                {
                    result.Add(number % baseTo);
                    number = number / baseTo;
                }
                result.Reverse();
                foreach (int item in result)
                {
                    Console.Write(stadigits[item]);
                }
                Console.Write(" ");
            }
            else
            {
                while (number > 0)
                {
                    result.Add(number % baseTo);
                    number = number / baseTo;
                }
                result.Reverse();
                foreach (int item in result)
                {
                    Console.Write(stadigits[item]);
                }
                Console.Write(" ");
            }
        }
    }
}
