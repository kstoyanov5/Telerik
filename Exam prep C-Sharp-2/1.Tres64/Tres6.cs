using System;
using System.Text;

namespace _1.Tres64
{
    class Tres6
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());

            var numeralSystem = 9;

            var digits = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            StringBuilder result = new StringBuilder();

            if (input == 0)
            {
                Console.WriteLine(digits[0]);
            }
            else
            {
                while (input > 0)
                {
                    int digitIn9th = (int)(input % (ulong)numeralSystem);

                    result.Insert(0, digits[digitIn9th]);

                    input /= (ulong)numeralSystem;
                }
                Console.WriteLine(result.ToString());
            }
        }
    }
}
