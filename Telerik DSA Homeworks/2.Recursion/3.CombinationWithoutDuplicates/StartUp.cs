/*
 * Modify the previous program to skip duplicates:
 * n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
 * 
 * https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/03.%20Recursion/homework
 */

namespace _3.CombinationWithoutDuplicates
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

            recursiveLoop(0, 0);
        }

        static void recursiveLoop(int counter, int index)
        {
            if (index >= K)
            {
                PrintLoops();
                return;
            }

            for (int i = counter; i < N; i++)
            {
                loops[index] = i;
                recursiveLoop(i + 1, index + 1);
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

