/**
 *  Write a program that reads a sequence of integers (List<int>) 
 *  ending with an empty line and sorts them in an increasing order.
 *  
 *  Link for the full description of the homework:
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */

namespace _3.SortSequence
{
    using System;
    using System.Collections.Generic;

    class SortSequence
    {
        static void Main(string[] args)
        {
            List<int> sortSequence = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "") break;

                int number = int.Parse(input);
                sortSequence.Add(number);
            }
            sortSequence.Sort();

            foreach (var item in sortSequence)
            {
                Console.Write(item + " ");
            }
        }
    }
}
