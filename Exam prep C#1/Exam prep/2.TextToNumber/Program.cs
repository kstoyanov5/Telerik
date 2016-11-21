using System;

namespace _2.TextToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            string textResult = Console.ReadLine();
            double result = 0;
            string text = textResult.ToLower();

            for(int i = 0; i< text.Length; i++)
            {
                char ch = text[i];

                if (ch == '@')
                {
                    break;
                }
                else if (Char.IsDigit(ch))
                {
                    result *= (ch - '0');
                }
                else if (Char.IsLetter(ch))
                {
                    result += (ch - 'a');
                }
                else
                {
                    result %= M;
                }
            }
            Console.WriteLine(result);
        }
    }
}
