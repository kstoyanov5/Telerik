using System;

namespace _2.Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());

            int maxSpeed = 1500;
            int highestLen = 0;
            int sCount = 1;

            int sum = 0;
            for (int i = 1; i <= c; i++)
            {
                int s = int.Parse(Console.ReadLine());
                if (s <= maxSpeed)
                {
                    maxSpeed = s;
                    if(sCount >= highestLen)
                    {
                        sum += s;
                        sCount++;
                        highestLen = sCount;
                    }
                    if (sCount == highestLen)
                    {

                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
