/**
 *  Write a program that removes from given sequence all numbers that occur odd number of times.
 *  
 *  Example:
 *  {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
 *  
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */

namespace _6.RemoveOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveOdds
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 });

            var evenNumbers = list.GroupBy(x => x).Where(x => x.Count() % 2 == 0).Select(g => g.Key);

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
