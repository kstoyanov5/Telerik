/*
 * 
 * Full description of the problem can be found at:
 * https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Workshops/2016/09-12-2016/OddNumber/README.md
 * 
 */
namespace _1.OddNumbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            long number = 0;
            for (int i = 0; i < n; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());
                number ^= currentNumber;
            }
            Console.WriteLine(number);
        }
    }
}
