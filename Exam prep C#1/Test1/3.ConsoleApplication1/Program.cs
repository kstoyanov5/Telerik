using System;
using System.Numerics;

namespace _3.ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            BigInteger globalProduct = 1;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                if (index == 10)
                {
                    Console.WriteLine(globalProduct);
                    globalProduct = 1;
                }

                long num = long.Parse(line);

                if (index % 2 == 1)
                {
                    long product = 1;
                    while (num > 0)
                    {
                        long digit = num % 10;
                        if (digit != 0)
                        {
                            product *= digit;
                        }
                        num /= 10;
                    }
                    globalProduct *= product;
                }
                index++;
            }
            Console.WriteLine(globalProduct);
        }
    }
}
