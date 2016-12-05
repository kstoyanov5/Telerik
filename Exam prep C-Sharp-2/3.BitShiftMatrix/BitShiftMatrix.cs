using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _3.BitShiftMatrix
{
    class BitShiftMatrix
    {
        static void Main()
        {
            int rowCount = int.Parse(Console.ReadLine());
            int colCount = int.Parse(Console.ReadLine());

            bool[,] matrix = new bool[rowCount, colCount];

            int numberOfSteps = int.Parse(Console.ReadLine());

            int row = rowCount - 1;
            int col = 0;      

            int coef = Math.Max(rowCount, colCount);
            var steps = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BigInteger currentCellValue = 1;
            BigInteger sum = 0;

            for (int i = 0; i < steps.Length; i++)
            {
                var nextRow = steps[i] / coef;
                var nextCol = steps[i] % coef;

                var deltaCol = col > nextCol ? -1 : 1;

                while (col != nextCol)
                {
                    if (matrix[row, col] != true)
                    {
                        sum += currentCellValue;
                        matrix[row, col] = true;
                    }
                    if (deltaCol == 1)
                    {
                        currentCellValue *= 2;
                    }
                    else
                    {
                        currentCellValue /= 2;
                    }
                    col += deltaCol;
                }

                var deltaRow = row > nextRow ? -1 : 1;

                while (row != nextRow)
                {
                    if (matrix[row, col] != true)
                    {
                        sum += currentCellValue;
                        matrix[row, col] = true;
                    }
                    if (deltaRow == 1)
                    {
                        currentCellValue /= 2;
                    }
                    else
                    {
                        currentCellValue *= 2;
                    }
                    row += deltaRow;
                }
            }
           if (matrix[row, col] != true)
           {
               sum += currentCellValue;
               matrix[row, col] = true;
           }
            Console.WriteLine(sum);
        }
    }
}
