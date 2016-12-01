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
                case "Rawr": return 0; 
                case "Rrrr": return 1; 
                case "Hsst": return 2; 
                case "Ssst": return 3; 
                case "Grrr": return 4; 
                case "Rarr": return 5; 
                case "Mrrr": return 6; 
                case "Psst": return 7; 
                case "Uaah": return 8; 
                case "Uaha": return 9; 
                case "Zzzz": return 10;
                case "Bauu": return 11;
                case "Djav": return 12;
                case "Myau": return 13;
                case "Gruh": return 14;  
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
