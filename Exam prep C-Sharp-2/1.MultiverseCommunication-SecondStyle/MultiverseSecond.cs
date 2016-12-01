using System;
using System.Numerics;

namespace _1.MultiverseCommunication_SecondStyle
{
    class MultiverseSecond
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
            string input = Console.ReadLine().Replace("CHU", "0")
                                             .Replace("TEL", "1")
                                             .Replace("OFT", "2")
                                             .Replace("IVA", "3")
                                             .Replace("EMY", "4")
                                             .Replace("VNB", "5")
                                             .Replace("POQ", "6")
                                             .Replace("ERI", "7")
                                             .Replace("CAD", "8")
                                             .Replace("K-A", "9")
                                             .Replace("IIA", ":")
                                             .Replace("YLO", ";")
                                             .Replace("PLA", "<");
            int power = 0;
            BigInteger result = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentNumber = input[i] - '0';
                result += currentNumber * Pow(13, power);
                power++;
            }
            Console.WriteLine(result);
        }
    }
}
