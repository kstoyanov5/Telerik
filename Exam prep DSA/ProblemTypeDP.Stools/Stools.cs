namespace ProblemTypeDP.Stools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Stools
    {

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var stool = new Stool[N];

            for (int i = 0; i < N; i++)
            {
                var line = Console.ReadLine().Split(' ');
                stool[i] = new Stool(int.Parse(line[0]), int.Parse(line[1]), int.Parse(line[2]));
            }
        }
    }

    class Stool
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Stool(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int compareTo(Stool o)
        {
            int area = o.Z * o.Y;
            int thisArea = this.Z * this.Y;

            return area - thisArea;
        }
    }
}
