using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemTypeCombinatorics.Bookshelf
{
    class BookShelf
    {
        static void Main(string[] args)
        {
            const long MOD = 1000000033;
            long MAXF = 1 << 17;
            long[] fact = new long[MAXF+1]{ 1, 1 };

            int mul;
            int sin;
            sin = int.Parse(Console.ReadLine());
            mul = int.Parse(Console.ReadLine());

            for (long i = 2; i <= MAXF; ++i)
            {
                fact[i] = fact[i - 1] * i % MOD;
            }

            long total = fact[sin + mul];

            if (mul > 0)
            {
                for (int i = 0; i < mul; ++i)
                {
                    int k;
                    k = int.Parse(Console.ReadLine());
                    total = total * fact[k] % MOD;
                }
            }

            Console.WriteLine(total);
        }
    }
}
