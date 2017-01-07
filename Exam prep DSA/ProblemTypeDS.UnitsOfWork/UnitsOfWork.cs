namespace ProblemTypeDS.UnitsOfWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class UnitsOfWork
    {
        static void Main()
        {
            var line = Console.ReadLine();

            while (line != "end")
            {

                line = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }

    public class Unit
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Attack { get; set; }
    }

    public class Command
    {
        public string Name { get; set; }

        public List<string> Arguments { get; set; }

        public static Command Parse(string commandAsString)
        {
            var commandParts = commandAsString.Split(' ');
            var newListOfStrings = new List<string>();

            var name = commandParts[0];

            for (int i = 1; i < commandParts.Length; i++)
            {
                newListOfStrings.Add(commandParts[i]);
            }

            return new Command
            {
                Name = name,
                Arguments = newListOfStrings
            };

        }
    }
}
