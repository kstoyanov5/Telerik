/**
 *  Write a program that removes from given sequence all negative numbers.
 *  
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */

namespace _5.RemoveNegatives
{
    using System;
    using System.Collections.Generic;

    class RemoveNegatives
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { -1, 5, 2, 3, 4 - 8, -7, 5, 5 });

            list.RemoveAll(i => i < 0);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
