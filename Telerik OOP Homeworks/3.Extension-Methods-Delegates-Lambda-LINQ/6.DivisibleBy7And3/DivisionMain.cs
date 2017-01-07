namespace _6.DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisionMain
    {
        static void Main()
        {
            int[] numbers = { 2, 5, 6, 7, 21, 28, 13, 42 };

            var output = DivisibleBy7and3(numbers);
            var outputLinq = DivisibleBy7and3Linq(numbers);

            foreach (var number in output)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Same but with LINQ:");
            foreach (var number in outputLinq)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static IEnumerable<int> DivisibleBy7and3(IEnumerable<int> inputArray)
        {
            IEnumerable<int> result =
                from number in inputArray
                where number % 21 == 0
                select number;
            return result;
        }

        static IEnumerable<int> DivisibleBy7and3Linq(IEnumerable<int> inputArray)
        {
            IEnumerable<int> result = inputArray.Where(number => number % 21 == 0);
            return result;
        }

    }
}
