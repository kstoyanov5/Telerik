/**
 * Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
 * how many times each of them occurs.
 * 
 * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
 *      2 → 2 times
 *      3 → 4 times
 *      4 → 3 times
 * 
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */
namespace _7.OccuringTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OccuringTimes
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 });

            var groups = list.GroupBy(v => v);

            foreach (var group in groups)
            {
                Console.WriteLine("{0} -> {1} times", group.Key, group.Count());
            }
        }
    }
}
