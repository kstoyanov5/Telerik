using System;

namespace _1.Cofee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double inMachine = n1 * 0.05 + n2 * 0.10 + n3 * 0.20 + n4 * 0.50 + n5;
            double sum = 0;

            if((A >= P)){
                Console.WriteLine("Yes {0:F2}", (inMachine - (A - P)));
            }          
            else            
                Console.WriteLine("More {0:F2}", (P - A));
            

        }
    }
}
