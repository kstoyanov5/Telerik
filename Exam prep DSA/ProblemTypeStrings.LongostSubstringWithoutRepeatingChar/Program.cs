namespace ProblemTypeStrings.LongostSubstringWithoutRepeatingChar
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int lengthOfLongestSubstring(String s)
        {
            HashSet<char> uniqueSet = new HashSet<char>();
            int maxSize = 0;
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!uniqueSet.Contains(s[i]))
                {
                    uniqueSet.Add(s[i]);
                    if (uniqueSet.Count > maxSize)
                    {
                        maxSize = uniqueSet.Count;
                    }
                }
                else
                {
                    while (s[start] != s[i])
                    {
                        uniqueSet.Remove(s[start]);
                        start++;
                    }
                    start++;
                }
            }
            return maxSize;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(lengthOfLongestSubstring("ABCDECAMNCZB"));
        }
    }
}
