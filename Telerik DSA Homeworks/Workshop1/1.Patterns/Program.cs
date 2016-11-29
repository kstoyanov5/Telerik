namespace _1.Patterns
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            uint input = uint.Parse(Console.ReadLine());

            List<char> startLine = new List<char> { 'u', 'r', 'd' };
            List<char> output = new List<char>();

            Dictionary<char, char> turnRight = new Dictionary<char, char>();
            turnRight.Add('d', 'r');
            turnRight.Add('r', 'u');
            turnRight.Add('u', 'l');
            turnRight.Add('l', 'd');

            Dictionary<char, char> turnLeft = new Dictionary<char, char>();
            turnLeft.Add('u', 'l');
            turnLeft.Add('r', 'd');
            turnLeft.Add('d', 'r');
            turnLeft.Add('l', 'u');

            for (int i = 0; i < input - 1; i++)
            {
                startLine.Reverse();

                for (int j = 0; j < startLine.Count; j++)
                {
                    output.Add(turnRight[startLine[j]]);
                }

                output.Add('u');
                startLine.Reverse();
                output.AddRange(startLine);

                output.Add('r');
                output.AddRange(startLine);
                output.Add('d');

                for (int j = 0; j < startLine.Count; j++)
                {
                    output.Add(turnLeft[startLine[j]]);
                }

                startLine.Clear();
                startLine = new List<char>(output);
                output.Clear();
            }

            Console.WriteLine(string.Join("", startLine));
        }
    }
}
