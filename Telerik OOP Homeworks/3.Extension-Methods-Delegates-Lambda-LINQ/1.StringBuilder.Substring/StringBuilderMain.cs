namespace _1.StringBuilder.Substring
{
    using System;
    using System.Text;

    static class StringBuilderMain
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Funny cats video");

            StringBuilder output = builder.Substring(0, 4);

            Console.WriteLine(output);
        }

        public static StringBuilder Substring(this StringBuilder input, int index, int lenght)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < index + lenght + 1; i++)
            {
                result.Append(input[i]);
            }
            return result;
        }
    }
}
