namespace ProblemTypeGraphs.PenguinAirlines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Penguin
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var adjList = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                if (line == "None")
                {
                    // Avoids null exepctions
                    adjList[i] = new List<int>();
                }
                else
                {
                    adjList[i] = line.Split(' ')
                        .Select(int.Parse)
                        .ToList();
                }
            }

            while (true)
            {
                var line = Console.ReadLine();

                if (line[0] == 'H')
                {
                    break;
                }

                var strs = line.Split(' ');
                int a = int.Parse(strs[0]);
                int b = int.Parse(strs[1]);

                if (adjList[a].Contains(b))
                {
                    Console.WriteLine("There is a direct flight.");
                }
                else
                {
                    var visited = new bool[n];
                    Dfs(a, adjList, visited);

                    if (visited[b])
                    {
                        Console.WriteLine("There are flights, unfortunately they are not direct, grandma :(");
                    }
                    else
                    {
                        Console.WriteLine("No flights available.");
                    }
                }
            }
        }

        static void Dfs(int x, List<int>[] adjList, bool[] visited)
        {
            visited[x] = true;

            foreach (var y in adjList[x])
            {
                if (!visited[y])
                {
                    Dfs(y, adjList, visited);
                }
            }
        }
    }
}
