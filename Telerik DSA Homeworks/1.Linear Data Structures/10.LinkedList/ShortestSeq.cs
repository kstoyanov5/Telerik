/**
 * We are given numbers N and M and the following operations:
 * 
 * N = N+1
 * N = N+2
 * N = N*2
 * 
 * Write a program that finds the shortest sequence of operations 
 * from the list above that starts from N and finishes in M.
 * 
 * Hint: use a queue.
 * Example: N = 5, M = 16
 * Sequence: 5 → 7 → 8 → 16
 * 
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */

namespace _10.LinkedList
{
    using System;
    using System.Collections.Generic;

    class ShortestSeq
    {
        // I used Stack instead of Queue because my loop is decreasing and adds elements backwards.
        // so when i print the numbers they come in the right order.

        // The output of my algorithm is different from the one in the example
        // but the answer is semantically correct.
        // E.g
        // My output: 5 -> 6 -> 8 -> 16

        static void Main(string[] args)
        {
            int N = 5;
            int M = 16;

            var stack = new Stack<int>();

            for (int i = M; i != N;)
            {
                if (i % 2 == 1 && (((i - 1) / 2) > N))
                {
                    stack.Push(i);
                    i = (i - 1) / 2;
                    stack.Push(i);
                }
                else if ((i % 2 == 0) && ((i / 2) > N))
                {
                    stack.Push(i);
                    i /= 2;
                    stack.Push(i);
                }
                else if (i - 2 >= N)
                {
                    i -= 2;
                    stack.Push(i);
                }
                else
                {
                    i--;
                    stack.Push(i);
                }
            }

            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
        }
    }
}
