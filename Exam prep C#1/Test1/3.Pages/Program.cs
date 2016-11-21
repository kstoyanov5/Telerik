using System;

namespace _3.Pages
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitNumber = int.Parse(Console.ReadLine());
            int pages = 0;

            for (int i = 1; digitNumber != 0; i++)
            {
                pages++;
                if(i < 10)
                {
                    digitNumber -= 1;
                }
                else if (i < 100)
                {
                    digitNumber -= 2;
                }
                else if (i < 1000)
                {
                    digitNumber -= 3;
                }
                else if (i < 10000)
                {
                    digitNumber -= 4;
                }
                else if (i < 100000)
                {
                    digitNumber -= 5;
                }
            }
            Console.WriteLine(pages);
        }
    }
}
