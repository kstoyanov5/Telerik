/**
 *  Write a method that finds the longest subsequence of 
 *  equal numbers in given List and returns the result as new List<int>.
 *  
 *  Write a program to test whether the method works correctly.
 *  
 *  https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Topics/02.%20Linear-Data-Structures/homework
 */

namespace _4.LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    class LongestSubsequence
    {
        static void Main(string[] args)
        {
            int count = 1, max = 1;
            var list = new List<int>(new int[] { 2, 2, 2, 1, 1, 3, 4, 5, 5, 5, 5, 5, 6, 7 });

            List<int> finalList = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > max)
                {
                    max = count;
                }
            }
            //We have 5 5's so expected output will be 5
            finalList.Add(max);
            foreach (var item in finalList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
