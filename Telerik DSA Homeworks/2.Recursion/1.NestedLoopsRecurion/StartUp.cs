/*
 * Write a recursive program that simulates the execution of n nested loops from 1 to n.
 * 
 * Examples:
 *          1 1
 * n=2  ->  1 2
 *          2 1
 *          2 2
 * 
 *          1 1 1
 *          1 1 2
 *          1 1 3
 *          1 2 1
 * n=3  ->  ...
 *          3 2 3
 *          3 3 1
 *          3 3 2
 *          3 3 3
 * 
 * https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/03.%20Recursion/homework
 */
namespace _1.NestedLoopsRecursion
{
    using System;

    class StartUp
    {
        // Set N here
        static int n = 3;

        static int[] loops;

        static void Main(string[] args)
        {
            loops = new int[n];
            recursiveLoop(0);
        }

        static void recursiveLoop(int currentLoop)
        {
            if (currentLoop == n)
            {
                Print();
                return;
            }
            for (int counter = 1; counter <= n; counter++)
            {
                loops[currentLoop] = counter;
                recursiveLoop(currentLoop + 1);
            }
        }

        static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
