using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace _1.CalculationProblem
{
    class CalculationProblem
    {
        static List<string> digits = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w" };

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger result = 0;
            int numeralSystem = 19;

            for (int i = 0; i < input.Length; i++)
            {
                var currentNum = input.Substring(i, 1);
                var decimalValue = digits.IndexOf(currentNum);

                result *= numeralSystem;
                result += decimalValue;
            }
        }

        static BigInteger Pow(int number, int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

    }
}
