using System;


namespace _2.Busses
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());

            int groups = 0;
            int groupSpeed = int.MaxValue;

            for (int i = 0; i < c; i++)
            {
                int speed = int.Parse(Console.ReadLine());

                if(speed <= groupSpeed)
                {
                    groupSpeed = speed;
                    groups++;
                }
            }
            Console.WriteLine(groups);
        }
    }
}
