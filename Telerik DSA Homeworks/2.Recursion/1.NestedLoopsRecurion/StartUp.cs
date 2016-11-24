/*
 * Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
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
 * 
 **/
namespace _1.NestedLoopsRecursion
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            int n = 3;

            recursiveLoop(n);
        }

        static void recursiveLoop(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            recursiveLoop(n - 1);
        }
    }
}
