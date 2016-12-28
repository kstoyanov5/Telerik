namespace ProblemTypeStrings.Matches
{
    using System;

    class Matches
    {
        static void Main()
        {
            var string1 = Console.ReadLine();
            var string2 = Console.ReadLine();

            int output = LongestCommonSubstringWithLessStorage(string1, string2);
            Console.WriteLine(output);
        }

        public static int LongestCommonSubstring(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                return 0;

            int[,] num = new int[str1.Length, str2.Length];
            int maxlen = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                        num[i, j] = 0;
                    else
                    {
                        if ((i == 0) || (j == 0))
                            num[i, j] = 1;
                        else
                            num[i, j] = 1 + num[i - 1, j - 1];

                        if (num[i, j] > maxlen)
                        {
                            maxlen = num[i, j];
                        }
                    }
                }
            }
            return maxlen;
        }

        public static int LongestCommonSubstringWithLessStorage(string s, string t)
        {
            int m = s.Length;
            int n = t.Length;
            int cost = 0;
            int maxLength = 0;
            int[] p = new int[n];
            int[] d = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (s[i] != t[j])
                    {
                        cost = 0;
                    }
                    else
                    {
                        if (i==0 || j==0)
                        {
                            cost = 1;
                        }
                        else
                        {
                            cost = p[j - 1] + 1;
                        }
                    }
                    d[j] = cost;

                    if (cost > maxLength)
                    {
                        maxLength = cost;
                    }
                }
                int[] swap = p;
                p = d;
                d = swap;
            }
            return maxLength;
        }
    }
}
