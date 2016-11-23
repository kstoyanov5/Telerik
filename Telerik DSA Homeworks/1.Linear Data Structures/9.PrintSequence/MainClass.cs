/**
 * We are given the following sequence:
 *
 * S1 = N;
 * S2 = S1 + 1;
 * S3 = 2*S1 + 1;
 * S4 = S1 + 2;
 * S5 = S2 + 1;
 * S6 = 2*S2 + 1;
 * S7 = S2 + 2;
 * ...
 * Using the Queue<T> class write a program to print its first 50 members for given N.
 * 
 * Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
 * 
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */
namespace _9.PrintSequence
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main(string[] args)
        {
            List<int> seq = new List<int>();

            Queue<int> queueInts = new Queue<int>();
            queueInts.Enqueue(2);

            for (int i = 1; i <= 50; i++)
            {
                int S = queueInts.Dequeue();
                seq.Add(S);

                queueInts.Enqueue(S + 1);
                queueInts.Enqueue(2 * S + 1);
                queueInts.Enqueue(S + 2);
            }

            foreach (var item in seq)
            {
                Console.Write(item + " ");
            }
        }
    }
}
