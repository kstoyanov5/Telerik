namespace _2.EvenDifferences
{
    using System;
    using System.Linq;

    class EvenDifferences
    {
        // 1. read input
        // 2. put the input numbers in a collection
        // 3. iterate over the collection and calculate the sum
        // 3.1 find absolute difference of current and the previous number
        // 3.2 if even difference, sum it
        // 3.3 make a jump - even or odd
        // 4. print the sum

        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long sum = 0;
            int index = 1;

            while (index < sequence.Length)
            {
                long absDiff = Math.Abs(sequence[index] - sequence[index - 1]);

                if (absDiff % 2 == 0)
                {
                    sum += absDiff;
                    index += 2;
                }
                else
                {
                    index++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
