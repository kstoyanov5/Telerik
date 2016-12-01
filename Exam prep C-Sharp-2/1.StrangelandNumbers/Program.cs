using System;
using System.Numerics;

namespace _1.StrangelandNumbers
{
    class Program
    {
        static BigInteger Pow(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace("f", "0")
                                             .Replace("bIN", "1")
                                             .Replace("oBJEC", "2")
                                             .Replace("mNTRAVL", "3")
                                             .Replace("lPVKNQ", "4")
                                             .Replace("pNWE", "5")
                                             .Replace("hT", "6");
            BigInteger inputResult = 0;
            int power = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentNumber = input[i] - '0';
                inputResult += currentNumber * Pow(7, power);
                power++;
            }
            Console.WriteLine(inputResult);
        }
    }
}
