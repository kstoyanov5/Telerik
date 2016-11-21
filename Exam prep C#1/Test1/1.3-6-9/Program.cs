using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());          

            int result = 0;
            if(b == 3)
            {
                result = a + c;
            }
            else if(b == 6) {
                result = a * c;
            }
            else if (b == 9)
            {
                result = a % c;
            }

            int secondResult = 0;

            if ((result % 3) == 0)
            {
                secondResult = result / 3;
            }
            else
                secondResult = result % 3;

            Console.WriteLine(secondResult);
            Console.WriteLine(result);
        }
    }
}
