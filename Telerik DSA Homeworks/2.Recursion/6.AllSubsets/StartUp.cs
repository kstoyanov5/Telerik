/*
 * Write a program for generating and printing all subsets of k strings from given set of strings.
 * Example: s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)
 * 
 * https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/03.%20Recursion/homework
 */

namespace _6.AllSubsets
{
    using System;

    class StartUp
    {
        static string[] set = { "test", "rock", "fun" };
        static int[] subSets;

        static int N = set.Length;
        static int K = 2;

        static void Main(string[] args)
        {
            subSets = new int[N];

            recursiveLoop(0, 0);
        }

        static void recursiveLoop(int index, int counter)
        {
            if (index >= K)
            {
                Print();
                return;
            }

            for (int i = counter; i < N; i++, counter++)
            {
                subSets[index] = i;
                recursiveLoop(index + 1, counter + 1);
            }
        }

        static void Print()
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write(set[subSets[i]] + " ");
            }
            Console.WriteLine();
        }
    }
}
