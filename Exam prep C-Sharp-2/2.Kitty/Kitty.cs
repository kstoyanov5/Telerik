using System;
using System.Linq;

namespace _2.Kitty
{
    class Kitty
    {
        static void Main(string[] args)
        {
            long souls = 0;
            long food = 0;
            long deadlocks = 0;

            char[] input = Console.ReadLine().ToCharArray();
            var path = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            bool[] boolArray = new bool[input.Length];
            long jumps = 0;
            int position = 0;
            long temp = 0;

            for (int i = 0; i <= path.Length; i++)
            {
                if (input[position] == '@' && boolArray[position] == false)
                {
                    souls++;
                    boolArray[position] = true;
                }
                else if (input[position] == '*' && boolArray[position] == false)
                {
                    food++;
                    boolArray[position] = true;
                }
                else if (input[position] == 'x')
                {
                    deadlocks++;
                    if (position % 2 == 0)
                    {
                        if (souls <= 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", jumps);
                            break;
                        }
                        souls--;
                        input[position] = '@';
                    }
                    else
                    {
                        if (food <= 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", jumps);
                            break;
                        }
                        food--;
                        input[position] = '*';
                    }
                }
                if (i == path.Length)
                {
                    Console.WriteLine("Coder souls collected: {0}", souls);
                    Console.WriteLine("Food collected: {0}", food);
                    Console.WriteLine("Deadlocks: {0}", deadlocks);
                    break;
                }

                temp += path[i];
                if (temp < 0)
                {
                    while (temp < 0)
                    {
                        temp = input.Length + temp;
                    }
                }
                else if (temp >= input.Length)
                {
                    while (temp >= input.Length)
                    {
                        temp %= input.Length;
                    }
                }
                position = (int)temp;
                jumps++;
            }
        }
    }
}
