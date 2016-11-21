using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double S = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double amountOfMoney = ((N*S)/500)*P;
            Console.Out.WriteLine("{0:F2}", amountOfMoney);
        }
    }
}
