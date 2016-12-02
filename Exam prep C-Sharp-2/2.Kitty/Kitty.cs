using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Kitty
{
    class Kitty
    {
        static void Main(string[] args)
        {

            int souls = 0;
            int food = 0;
            int deadlocks = 0;

            string input = Console.ReadLine();
            string path = Console.ReadLine();


            for (int position = 0; position < input.Length; position++)
            {
                if (input[position] == '@')
                {
                    souls++;
                }
                else if (input[position] == '*')
                {
                    food++;
                }
                else if(input[position] == 'x')
                {
                    if (input[position] % 2 == 0)
                    {
                        souls--;
                    }
                    else
                        food--;
                }
            }

            Console.WriteLine("Souls" + souls);
            Console.WriteLine("Food" + food);
            Console.WriteLine("Deadlocks" + deadlocks);
        }
    }
}
