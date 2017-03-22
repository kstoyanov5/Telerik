namespace _03.Loop
{
    using System;

    class LoopStartup
    {
        public static void Main()
        {
            int expectedValue = 666;
            int[] numbers = FillArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(numbers[i]);

                    if (numbers[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        private static int[] FillArray()
        {
            var randomGen = new Random();
            var numbers = new int[100];

            for (int i = 0; i < 100; i++)
            {
                numbers[i] = randomGen.Next(650, 680);
            }

            return numbers;
        }
    }
}
