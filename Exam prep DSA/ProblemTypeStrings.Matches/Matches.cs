namespace ProblemTypeStrings.Matches
{
    using System;

    class Matches
    {
        static void Main()
        {
            var string1 = Console.ReadLine();
            var string2 = Console.ReadLine();

            int output = LongestCommonSubstring(string1, string2);
            Console.WriteLine(output);
        }

        /* Runs in O(n*m) time, storage is O(n*m) */
        public static int LongestCommonSubstring(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
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

        /* Runs in O(n*m) time, storage is O(n) */
        public static int LongestCommonSubstringWithLessStorage(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                return 0;

            int m = str1.Length;
            int n = str2.Length; 
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            int cost = 0;
            int maxLength = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (str1[i] != str2[j])
                    {
                        cost = 0;
                    }
                    else
                    {
                        if (i == 0 || j == 0)
                        {
                            cost = 1;
                        }
                        else
                        {
                            cost = arr1[j - 1] + 1;
                        }
                    }
                    arr2[j] = cost;

                    if (cost > maxLength)
                    {
                        maxLength = cost;
                    }
                }
                int[] swap = arr1;
                arr1 = arr2;
                arr2 = swap;
            }
            return maxLength;
        }
    }
}
