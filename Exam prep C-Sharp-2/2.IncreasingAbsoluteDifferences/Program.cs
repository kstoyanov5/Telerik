namespace _2.IncreasingAbsoluteDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var line = int.Parse(Console.ReadLine());
            List<string> output = new List<string>();

            while (line > 0)
            {
                var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                bool isIncreasing = true;

                for (int j = 2; j < input.Length; j++)
                {
                    var absDiff = Math.Abs(input[j - 1] - input[j]);
                    var lastAbsDiff = Math.Abs(input[j - 2] - input[j - 1]);

                    if (lastAbsDiff > absDiff || absDiff - lastAbsDiff > 1) 
                    {
                        isIncreasing = false;
                        break;
                    }
                }
                output.Add(isIncreasing.ToString());
                line--;
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
