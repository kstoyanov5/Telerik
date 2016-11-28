using System;

namespace _2.BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] answers = new int[count];

            for (int i = 0; i < count; i++)
            {
                answers[i] = int.Parse(Console.ReadLine());
            }

            int solution = getMinimum(answers);
            Console.WriteLine(solution);
        }

        private static int getMinimum(int[] answers)
        {
            int[] temp = new int[1000002];

            for (int i = 0; i < answers.Length; i++)
            {
                temp[answers[i] + 1]++;
            }

            int minimumCount = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 0)
                {
                    continue;
                }
                if (temp[i] <= i)
                {
                    minimumCount += i;
                }
                else minimumCount += (int)Math.Ceiling((double)temp[i] / i) * i;
            }
            return minimumCount;
        }
    }
}
