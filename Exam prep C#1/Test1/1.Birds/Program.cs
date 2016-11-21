using System;

namespace _1.Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            double ave = n2/n1;
            double result = 1;

            if (n1 % 2 == 0)
            {
                result = ave * 123123123123;
            }
            else
                result = ave / 317;

            Console.WriteLine("{0:F4}", result);
            //Console.WriteLine("{0:F4}", 0.45* 123123123123);
        }
    }
}
