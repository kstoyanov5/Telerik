using System;

namespace _4.Batman
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            Char asci = Char.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                Console.Write(new string(asci, s - i));
                Console.Write(new string('0', s));
                Console.Write(new string(asci, s - i));
                Console.WriteLine();
            }
        }
    }
}
