namespace ProblemTypeCombinatorics.Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Game
    {
        static double[,] memo = new double[128, 128];

        private static double game(int x, int y, double p)
        {
            if (x == 0 && y == 0)
            {
                return 1;
            }

            if (memo[x, y] < 0)
            {
                if (x == 0)
                {
                    memo[x, y] = (1 - p) * game(0, y - 1, p);
                }

                else if (y == 0)
                {
                    memo[x, y] = 0;
                }

                else
                {
                    memo[x, y] = p * game(x - 1, y, p) + (1 - p) * game(x, y - 1, p);
                }
            }

            return memo[x, y];
        }


        static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());
            p /= 100;

            for (int i = 0; i <= n; ++i)
            {
                for (int j = 0; j <= n; ++j)
                {
                    memo[i, j] = -5;
                }
            }

            double chance = 0;
            if (k == n)
            {
                for (int i = 0; i < n; ++i)
                {
                    chance += game(i, n, 1 - p);
                }
            }
            else
            {
                chance = game(k, n, p);
            }

            Console.WriteLine("{0:F2}", (chance * 100));
        }
    }
}
