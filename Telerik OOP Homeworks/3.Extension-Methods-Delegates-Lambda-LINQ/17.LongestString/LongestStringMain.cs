namespace _17.LongestString
{
    using System;
    using System.Linq;

    static class LongestStringMain
    {
        static void Main()
        {
            string[] input =
            {
                "Hello from Pesho",
                "HE can type very fast on the keyboard",
                "but he can't count",
                "help him pls",
                "to count the longest sentence"
            };

            Console.WriteLine("The longest sentence is: " + LongestString(input));
        }

        public static string LongestString(string[] input)
        {
            var longestString =
                from line in input
                orderby (line.Length) descending
                select line;

            return longestString.First();
        }
    }
}
