using System;

namespace _2.Decoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            int position = 0;

            while (true)
            {
                // Reading as int because it will be used later in the task
                int charCode = Console.Read();
                char ch =  (char) charCode;
                int newCode = 1;

                if (ch == '@')
                {
                    break;
                }
                if (Char.IsLetter(ch))
                {
                    newCode = charCode * salt + 1000;
                }
                else if(Char.IsDigit(ch))
                {
                    newCode = charCode + salt + 500;
                }
                else
                {
                    newCode = charCode - salt;
                }
                if (position % 2 == 0)
                {
                    Console.WriteLine("{0:0.00}", newCode / 100.0);
                }
                else
                {
                    Console.WriteLine("{0:0.00}", newCode * 100.0);
                }

                position++;               
            }
        }
    }
}
