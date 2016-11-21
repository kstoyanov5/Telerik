using System;
using System.Numerics;

namespace _3.SaddyKopper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int transCount = 0;

            while (input.Length > 1 && transCount < 10) {

                BigInteger totalSum = 1;

                while (input.Length > 1)
                {
                    input = input.Substring(0, input.Length - 1);

                    Int64 sum = 0;

                    for (int i = 0; i < input.Length; i += 2)
                    {
                        sum += (input[i] - '0');
                    }

                    totalSum *= sum;
                }

                transCount++;
                input = totalSum.ToString();
            }

            if( transCount < 10)
            {
                Console.WriteLine(transCount);
            }

            Console.WriteLine(input);
        }
    }
}
