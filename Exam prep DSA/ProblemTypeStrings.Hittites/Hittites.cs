namespace ProblemTypeStrings.Hittites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Node
    {
        private Node[] letter;
        private Node failLink;
        private Node successLink;
        private bool isNameMatched;
        private double stringCount;

        public Node()
        {
            stringCount = 0;
            isNameMatched = false;
            failLink = null;
            successLink = null;
            letter = new Node[26];
        }

        public void Push(string name)
        {
            Node node = this;
            foreach (var ch in name)
            {
                int index = ch - 'a';
                if (node.letter[index] == null)
                {
                    node.letter[index] = new Node();
                }
                node = node.letter[index];
            }
            node.isNameMatched = true;
        }

        public void PreCompute()
        {
            var queue = new Queue<Node>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();

                for (int i = 0; i < 26; i++)
                {
                    if (node.letter[i] == null)
                    {
                        continue;
                    }
                    Node x = node.failLink;
                    while (x != null && x.letter[i] == null)
                    {
                        x = x.failLink;
                    }

                    node.letter[i].failLink = (x == null) ? this : x.letter[i];
                }
            }
        }

        public void AddStrings(double count)
        {
            stringCount += count;
        }

        public double getCount()
        {
            return stringCount;
        }

        public double CountMatches(int k)
        {
            var list = new List<Node>();
            list.Add(this);
            this.AddStrings(Hittites.Pow(26, k));

            for (int i = 0; i < k; i++)
            {
                var newQueue = new List<Node>();
                foreach (var node in list)
                {
                    double count = node.getCount();
                    if (count == 0)
                    {
                        continue;
                    }
                    node.stringCount = 0;
                    count = count * Hittites.DIV26 % Hittites.MOD;

                    for (int j = 0; j < 26; j++)
                    {
                        if (node.letter[j] == null)
                        {
                            Node x = node.failLink;
                            while (x != null && x.letter[j] == null)
                            {
                                x = x.failLink;
                            }
                            if (x == null)
                            {
                                this.AddStrings(count);
                                newQueue.Add(this);
                            }
                            else
                            {
                                x.letter[j].AddStrings(count);
                                newQueue.Add(x.letter[j]);
                            }
                        }
                        else
                        {
                            node.letter[j].AddStrings(count);
                            newQueue.Add(node.letter[j]);
                        }
                    }
                }
                list = newQueue;
                return this.getCount();
            }
        }
    }

    class Hittites
    {
        public const long MOD = (long)1e9 + 7;
        public static readonly double DIV26 = Pow(26, MOD - 2);

        static void Main()
        {
            var strs = Console.ReadLine().Split(' ');

            int k = int.Parse(strs[0]);
            int n = int.Parse(strs[1]);

            var root = new Node();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                root.Push(name);
            }
            root.PreCompute();

            double matches = root.CountMatches(k);
            Console.WriteLine(matches);
        }

        public static double Pow(long a, long b)
        {
            if (b == 0) return 1;
            if (b == 1) return a;
            double t = Pow(a, b / 2);
            return t * t * Pow(a, b % 2);
        }
    }
}
