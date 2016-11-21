using System;

namespace _4.Persian
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            Char ch = Char.Parse(Console.ReadLine());
            int width = 2 * N + 1;

            for (int row = 0; row < N; row++)
            {
                Console.Write(new string(ch, row));
                Console.Write('\\');
                int spaceLeft = width - row - row - 1 - 1 - D - D;
                if (spaceLeft >=2)
                {
                    Console.Write(new string(' ', D));
                    Console.Write('\\');
                    Console.Write(new string('.', spaceLeft - 2));
                    Console.Write('/');
                    Console.Write(new string(' ', D));
                }
                else
                {
                    Console.Write(new string(' ', width-row-row-1-1));
                }
                Console.Write('/');
                Console.Write(new string(ch, row));
                Console.WriteLine();
            }
            Console.WriteLine(new string(ch, N) + 'X' + new string(ch, N));

            for (int row = N - 1; row >= 0; row--)
            {
                Console.Write(new string(ch, row));
                Console.Write('/');
                int spaceLeft = width - row - row - 1 - 1 - D - D;
                if (spaceLeft >= 2)
                {
                    Console.Write(new string(' ', D));
                    Console.Write('/');
                    Console.Write(new string('.', spaceLeft - 2));
                    Console.Write('\\');
                    Console.Write(new string(' ', D));
                }
                else
                {
                    Console.Write(new string(' ', width - row - row - 1 - 1));
                }
                Console.Write('\\');
                Console.Write(new string(ch, row));
                Console.WriteLine();
            }
        }
    }
}
