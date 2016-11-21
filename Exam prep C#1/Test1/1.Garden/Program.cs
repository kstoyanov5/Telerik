using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoSeeds = double.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            double cucumberSeeds = double.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            double potatoSeeds = double.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            double carrotSeeds = double.Parse(Console.ReadLine());
            int n8 = int.Parse(Console.ReadLine());
            double cabbageSeeds = double.Parse(Console.ReadLine());
            int n10 = int.Parse(Console.ReadLine());
            double beansSeeds = double.Parse(Console.ReadLine());

            double cost = tomatoSeeds * 0.5 + cucumberSeeds * 0.4 + potatoSeeds * 0.25 + carrotSeeds * 0.6 + cabbageSeeds * 0.3 + beansSeeds * 0.4;
            int totalArea = 250;
            int area = n2 + n4 + n6 + n8 + n10;
           
            Console.WriteLine("{0:F2}",cost);

            if (area < totalArea)
            {
                Console.WriteLine(totalArea - area);
            }
            else if (area > totalArea)
                Console.WriteLine("insuff");
            else if (area == totalArea)
                Console.WriteLine("beanz");
        }
    }
}
