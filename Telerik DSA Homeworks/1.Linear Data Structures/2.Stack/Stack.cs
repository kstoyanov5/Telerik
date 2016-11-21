/**
 *  Write a program that reads N integers from the console and reverses them using a stack.
 *  Use the Stack<int> class.
 *  
 *  Link for the full description of the homework:
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */

namespace _2.Stack
{
    using System;
    using System.Collections.Generic;

    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "") break;

                int number = int.Parse(input);
                stack.Push(number);
            }

            while (stack.Count > 0)
            {
                int outputNum = stack.Pop();
                Console.WriteLine(outputNum);
            }
        }
    }
}
