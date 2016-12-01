using System;
using System.Numerics;
using System.Collections.Generic;

namespace _1.CryptoCS
{
    class Crypto
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string thirdLine = Console.ReadLine();

            ulong numeralSystem = 26;
            int numeralSystem2 = 7;

            var digits = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            BigInteger result1 = 0;
            BigInteger result2 = ConvertToDecimal(thirdLine, numeralSystem2);
            BigInteger resultFinal;

            for (int i = 0; i < firstLine.Length; i++)
            {
                var currentNum = firstLine.Substring(i, 1);
                var decimalValue = digits.IndexOf(currentNum);

                result1 *= numeralSystem;
                result1 += decimalValue;
            }

            if (secondLine == "+")
            {
                resultFinal = result1 + result2;
                ConvertFromDecimal(resultFinal, 9);
            }
            else
            {
                resultFinal = result1 - result2;
                ConvertFromDecimal(resultFinal, 9);
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

        static void ConvertFromDecimal(BigInteger number, ulong baseTo)
        {
            List<BigInteger> result = new List<BigInteger>();
            while (number > 0)
            {
                result.Add(number % baseTo);
                number = number / baseTo;
            }
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static BigInteger ConvertToDecimal(string number, int baseFrom)
        {
            BigInteger decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > '9')
                {
                    decimalNumber += (number[i] - '7') * Pow(baseFrom, (number.Length - 1 - i));
                }
                else
                {
                    decimalNumber += (number[i] - '0') * Pow(baseFrom, (number.Length - 1 - i));
                }
            }
            return decimalNumber;
        }
    }
}
