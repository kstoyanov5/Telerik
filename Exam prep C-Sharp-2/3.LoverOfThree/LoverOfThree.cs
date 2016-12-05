namespace _3.LoverOfThree
{
    using System;
    using System.Linq;

    class LoverOfThree
    {
        // 1. Read Input and create boolean matrix.
        // 2. Read direction.
        // 2.1 Go in that direction until possible.
        // 2.2 Sum cells on the way with the formula.
        // 2.3 Read another direction.
        // 3 Print result.
        static void Main()
        {
            var fieldSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rowsCount = fieldSizes[0];
            var colsCount = fieldSizes[1];

            var field = new bool[rowsCount, colsCount];

            var n = int.Parse(Console.ReadLine());

            long result = 0;

            // Be careful for input count;
            int row = rowsCount - 1;
            int col = 0;

            for (int i = 0; i < n; i++)
            {
                var move = Console.ReadLine().Split(' ');
                var direction = move[0];
                var repeats = int.Parse(move[1]);

                var deltaRow = direction.Contains("U") ? -1 : 1;
                var deltaCol = direction.Contains("L") ? -1 : 1;

                for (int j = 1; j < repeats; j++)
                {
                    if (IsInside(row + deltaRow, col + deltaCol, field))
                    {
                        row += deltaRow;
                        col += deltaCol;

                        if (!field[row, col])
                        {
                            result += col * 3 + (rowsCount - 1 - row) * 3;
                            field[row, col] = true;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
            }
            Console.WriteLine(result);
        }

        static bool IsInside(int row, int col, bool[,] matrix)
        {
            bool rowIsInField = 0 <= row && row < matrix.GetLength(0);
            bool colIsInField = 0 <= col && col < matrix.GetLength(1);

            return rowIsInField && colIsInField;
        }
    }
}
