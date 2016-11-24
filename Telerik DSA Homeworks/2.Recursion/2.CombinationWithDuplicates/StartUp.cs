/*
 * Write a recursive program for generating and printing all the combinations with 
 * duplicates of k elements from n-element set.
 * 
 * Example: n = 3, k = 2 -> (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
 * 
 * https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/03.%20Recursion/homework
 */
namespace _2.CombinationWithDuplicates
{
    using System;

    class StartUp
    {
        static int N = 4;
        static int K = 2;
        static int[] loops;

        static void Main()
        {
            loops = new int[N];

            recursiveLoop(0);
        }

        static void recursiveLoop(int index)
        {
            if (index >= K)
            {
                PrintLoops();
                return;
            }

            for (int i = 0; i < N; i++)
            {
                loops[index] = i;
                recursiveLoop(i);
            }
        }

        static void PrintLoops()
        {
            Console.Write("(");
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0}", loops[i] + 1);
            }
            Console.Write(") ");
        }
    }
}
