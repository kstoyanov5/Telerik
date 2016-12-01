using System;

namespace _1.Zerg___
{
    class Zerg
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var numericSystem = 15;

            long result = 0;
            int position = input.Length / 4 - 1;

            for (int i = 0; i < input.Length; i += 4)
            {
                string currentDigit = input.Substring(i, 4);
                result += Convert(currentDigit) * Pow(numericSystem, position);
                position--;
            }
            Console.WriteLine(result);
        }

        static int Convert(string currentDigit)
        {
            switch (currentDigit)
            {
                case "Rawr": return 0; break;
                case "Rrrr": return 1; break;
                case "Hsst": return 2; break;
                case "Ssst": return 3; break;
                case "Grrr": return 4; break;
                case "Rarr": return 5; break;
                case "Mrrr": return 6; break;
                case "Psst": return 7; break;
                case "Uaah": return 8; break;
                case "Uaha": return 9; break;
                case "Zzzz": return 10; break;
                case "Bauu": return 11; break;
                case "Djav": return 12; break;
                case "Myau": return 13; break;
                case "Gruh": return 14; break;
                default: throw new ArgumentException();
            }
        }

        static long Pow(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
