namespace ProblemTypeStrings.RepeatingPattern
{
    using System;

    class RepeatingPattern
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int[] fl = new int[input.Length + 1];
            fl[0] = -1;
            fl[1] = 0;

            int j;
            for (int i = 1; i < input.Length; i++)
            {
                j = fl[i];
                while (j >= 0 && input[i] != input[j])
                {
                    j = fl[j];
                }

                fl[i + 1] = j + 1;
            }

            j = 0;
            for (int i = 1; ; i++)
            {
                if (i == input.Length)
                {
                    i = 0;
                }

                while (j >= 0 && input[i] != input[j])
                {
                    j = fl[j];
                }

                j++;

                if (j == input.Length)
                {
                    j = i + 1;
                    break;
                }
            }

            Console.WriteLine(input.Substring(0, j));
        }
    }
}
