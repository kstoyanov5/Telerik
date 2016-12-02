using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace _1.CalculationProblem
{
    class CalculationProblem
    {
        static List<string> digits = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w" };
        static int numeralSystem = 23;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] splits = input.Split(' ');
            StringBuilder builder = new StringBuilder();
            List<BigInteger> final = new List<BigInteger>();

            BigInteger result = 0;

            for (int i = 0; i < splits.Length; i++)
            {
                for (int j = 0; j < splits[i].Length; j++)
                {
                    var currentNum = splits[i].Substring(j, 1);
                    var decimalValue = digits.IndexOf(currentNum);

                    result *= numeralSystem;
                    result += decimalValue;
                }
                final.Add(result);
                result = 0;
            }

            BigInteger total = 0;
            foreach (var item in final)
            {
                total += item;
            }
            Console.WriteLine("{0} = {1}", ConvertFromDecimal(total, 23), total);
        }

        static string ConvertToInt(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                result += digits.IndexOf(word[i].ToString());
            }
            return result;
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

        static String ConvertFromDecimal(BigInteger number, int baseTo)
        {
            List<BigInteger> result = new List<BigInteger>();
            StringBuilder builder = new StringBuilder();
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
                    //Console.Write(digits[item]);
                    builder.Append(digits[item]);
                }
                //Console.Write(" ");
                return builder.ToString();
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
                    //Console.Write(digits[item]);
                    builder.Append(digits[item]);
                }
                return builder.ToString();
                //Console.Write(" ");
            }
        }
    }
}
