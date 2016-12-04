using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ExamProblem3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            var fieldSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rowsCount = fieldSizes[0];
            var colsCount = fieldSizes[1];

            var field = new bool[rowsCount, colsCount];

            var n = int.Parse(Console.ReadLine());

            long result = 0;




            Console.WriteLine(result);
        }
    }
}
