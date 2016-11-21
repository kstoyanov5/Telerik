using System;

namespace _5.BitsInBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int currentZeroCount = 0;
            int maxZeroCount = 0;

            int currentOneCount = 0;
            int maxOneCount = 0;

            int lastBit = 2;

            for (int i = 0; i < numberCount; i++)
            {
                int num = int.Parse(Console.ReadLine());

                for (int j = 29; j >= 0; j--)
                {
                    int bit = ((1 << j) & num) >> j;

                    if (bit == 1)
                    {
                        if (lastBit == 1)
                        {
                            currentOneCount++;
                            maxOneCount = Math.Max(maxOneCount, currentOneCount);
                        }
                        else
                        {
                            currentZeroCount = 0;
                            currentOneCount = 1;
                        }
                    }
                    else // bit == 0
                    {
                        if (lastBit == 0)
                        {
                            currentZeroCount++;
                            maxZeroCount = Math.Max(maxZeroCount, currentZeroCount);
                        }
                        else
                        {
                            currentOneCount = 0;
                            currentZeroCount = 1;
                        }
                    }
                    lastBit = bit;
                }
            }
            Console.WriteLine(maxZeroCount);
            Console.WriteLine(maxOneCount);
        }
    }
}
