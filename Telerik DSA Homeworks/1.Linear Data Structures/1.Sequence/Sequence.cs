/**
 *  Write a program that reads from the console a sequence of positive integer numbers.
 *  The sequence ends when empty line is entered.
 *  Calculate and print the sum and average of the elements of the sequence.
 *  Keep the sequence in List<int>.
 *  
 *  Link for the full description of the homework:
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */

namespace _1.Sequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Sequence
    {
        static void Main(string[] args)
        {
            List<int> sequenceList = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "") break;      
                    
                int number = int.Parse(input);
                sequenceList.Add(number);
            }
            var sum = sequenceList.Sum(x => x);
            var average = sequenceList.Average(x => x);
            Console.WriteLine(sum + " " + average);
        }
    }
}
