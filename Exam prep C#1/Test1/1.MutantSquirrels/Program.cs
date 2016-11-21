using System;

namespace _1.MutantSquirrels
{
    class Program
    {
        static void Main(string[] args)
        {
            const double divisor = 7.00;

            ulong n1 = ulong.Parse(Console.ReadLine());
            uint n2 = uint.Parse(Console.ReadLine());
            uint n3 = uint.Parse(Console.ReadLine());
            uint n4 = uint.Parse(Console.ReadLine());
            double tailBig = n4 * n3 * n2 * n1;

            if (tailBig % 2 == 0)
            {
                tailBig *= 376439;
            }
            else
            {
                tailBig /= divisor;
            }

            Console.WriteLine("{0:F3}", tailBig);
        }
    }
}
