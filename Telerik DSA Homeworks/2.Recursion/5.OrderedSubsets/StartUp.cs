/*
 * Write a recursive program for generating and printing all ordered k-element subsets
 * from n-element set (variations Vkn).
 * 
 * Example: n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
 * 
 * https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/03.%20Recursion/homework
 */

namespace _5.OrderedSubsets
{
    using System;

    class StartUp
    {
        static string[] set = { "hi", "a", "b" };
        static int[] subSets;

        static int N = set.Length;
        static int K = 2;

        static void Main(string[] args)
        {
            subSets = new int[N];

            recursiveLoop(0);
        }

        static void recursiveLoop(int index)
        {
            if (index >= K)
            {
                Print();
                return;
            }

            for (int i = 0; i < N; i++)
            {
                subSets[index] = i;
                recursiveLoop(index + 1);
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
