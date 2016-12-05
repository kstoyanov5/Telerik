using System;

namespace _5.BobbyAvokadoto
{
    class BobbyAvokadoto
    {
        static void Main(string[] args)
        {
            int head = int.Parse(Console.ReadLine());
            int combCount = int.Parse(Console.ReadLine());

            int bestComb = 0;
            int bestCount = 0;
            for (int i = 0; i < combCount; i++)
            {
                int comb = int.Parse(Console.ReadLine());
                int currentCount = 0;
                // is comb valid
                if ((head & comb) == 0)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        currentCount += ((comb >> j) & 1);
                    }

                    //check if best
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestComb = comb;
                    }
                }
            }
            Console.WriteLine(bestComb);
        }
    }
}
