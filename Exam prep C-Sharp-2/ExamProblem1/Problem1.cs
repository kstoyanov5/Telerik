using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamProblem1
{
    class Problem1
    {
        static List<string> digits = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        static int numeralSystem = 23;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            /* Use if input is on one line*/
            //string[] splits = input.Split(' ');

            BigInteger result = 0;

            /* Returns result in decimal system from numeralSystem with letters(digits)
            //
            for (int i = 0; i < input.Length; i++)
            {
                var currentNum = input.Substring(i, 1);
                var decimalValue = digits.IndexOf(currentNum);

                result *= numeralSystem;
                result += decimalValue;
            }
            Console.WriteLine(result);
            */
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
                    /* Uncomment for Hexadecimal */
                    //switch (item)
                    //{
                    //    case 10: Console.Write('A'); break;
                    //    case 11: Console.Write('B'); break;
                    //    case 12: Console.Write('C'); break;
                    //    case 13: Console.Write('D'); break;
                    //    case 14: Console.Write('E'); break;
                    //    case 15: Console.Write('F'); break;
                    //    default: Console.Write(item); break;
                    //}
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
