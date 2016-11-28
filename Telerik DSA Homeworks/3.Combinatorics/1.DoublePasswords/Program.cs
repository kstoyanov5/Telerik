namespace _1.DoublePasswords
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {                      
            string templatePassword = Console.ReadLine();

            int unknownDigits = 0;

            for (int i = 0; i < templatePassword.Length; i++)
            {
                if (templatePassword[i] == '*')
                {
                    unknownDigits++;
                }
            }

            long answer = 1;
            for (int i = 1; i <= unknownDigits; i++)
            {
                answer *= 2;
            }
            Console.WriteLine(answer);
        }
    }
}
