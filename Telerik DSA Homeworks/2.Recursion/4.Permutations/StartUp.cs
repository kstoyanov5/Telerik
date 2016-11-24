/*
 * Write a recursive program for generating and printing all permutations of the
 * numbers 1, 2, ..., n for given integer number n. 
 * 
 * Example: n=3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
 * 
 * https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/03.%20Recursion/homework
 */

namespace _4.Permutations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        // Set N here
        static int N = 3;

        static int[] array;

        static void Main()
        {
            array = Enumerable.Range(1, N).ToArray();        

            recursiveLoop(N - 1);
        }

        static void recursiveLoop(int index)
        {
            if (index == 0)
            {
                PrintN();
                return;
            }
            recursiveLoop(index - 1);

            for (int i = 0; i < index; i++)
            {
                Swap(i, index, array);
                recursiveLoop(index - 1);
                Swap(i, index, array);
            }
        }

        static void Swap(int firstIndex, int secondIndex, int[] array)
        {
            var temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        static void PrintN()
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}", array[i]);
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
