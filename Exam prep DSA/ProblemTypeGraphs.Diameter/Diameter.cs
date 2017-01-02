namespace ProblemTypeGraphs.Diameter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Diameter
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            var neighbours = new List<Tuple<int, int>>[N];


            for (int i = 1; i < N; i++)
            {
                var nums = Console.ReadLine().Split(' ');
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);
                int len = int.Parse(nums[2]);

                if (neighbours[a] == null)
                {
                    neighbours[a] = new List<Tuple<int, int>>();
                }
                neighbours[a].Add(new Tuple<int, int>(b, len));

                if (neighbours[b] == null)
                {
                    neighbours[b] = new List<Tuple<int, int>>();
                }
                neighbours[b].Add(new Tuple<int, int>(a, len));

            }

            int maxIndex = 0;

            var visited = new bool[N];
            var path = new int[N];

            path[0] = 0;
            Dfs(0, neighbours, visited, path);

            for (int j = 0; j < N; j++)
            {
                if (path[maxIndex] < path[j])
                {
                    maxIndex = j;
                }
            }

            visited = new bool[N];
            path = new int[N];
            Dfs(maxIndex, neighbours, visited, path);

            Console.WriteLine(path.Max());
        }

        static void Dfs(int x, List<Tuple<int, int>>[] neighbours, bool[] visited, int[] path)
        {
            visited[x] = true;
            foreach (var edge in neighbours[x])
            {
                if (visited[edge.Item1])
                {
                    continue;
                }

                path[edge.Item1] = path[x] + edge.Item2;
                Dfs(edge.Item1, neighbours, visited, path);
            }
        }
    }
}
