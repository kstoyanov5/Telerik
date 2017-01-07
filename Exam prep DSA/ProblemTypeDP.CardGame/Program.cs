using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTypeDP.CardGame
{
    class Program
    {
        private const int MAXN = 2048;

        private static Tuple<int, int>[,] A = new Tuple<int, int>[MAXN, MAXN];

        private static int[] cards = new int[MAXN];

        static void Main(string[] args)
        {

            int n;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                cards[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; ++i)
            {
                A[i, i + 1] = { cards[i], 0};
            }

            for (int i = 2; i <= n; ++i)
            {
                for (int j = i; j <= n; ++j)
                {
                    A[j - i, j] = A[j - i + 1, j].Item1 < A[j - i, j - 1].Item1 ? pii(cards[j - i] + A[j - i + 1, j].Item2, A[j - i + 1, j].Item1) : pii(cards[j - 1] + A[j - i, j - 1].Item2, A[j - i, j - 1].Item1);
                }
            }

            Console.Write(A[0, n].Item1);
            Console.Write(' ');
            Console.Write(A[0, n].Item2);
            Console.Write('\n');
        }
    }
}
