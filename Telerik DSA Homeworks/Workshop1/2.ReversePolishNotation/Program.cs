namespace _2.ReversePolishNotation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Stack<long> inputProcessor = new Stack<long>();

            foreach (var item in input)
            {
                switch (item)
                {
                    case "+":
                        inputProcessor.Push(inputProcessor.Pop() + inputProcessor.Pop());
                        break;
                    case "-":
                        {
                            long temp = inputProcessor.Pop();
                            inputProcessor.Push(inputProcessor.Pop() - temp);
                            break;
                        }
                    case "*":
                        inputProcessor.Push(inputProcessor.Pop() * inputProcessor.Pop());
                        break;
                    case "/":
                        {
                            long temp = inputProcessor.Pop();
                            inputProcessor.Push(inputProcessor.Pop() / temp);
                            break;
                        }
                    case "&":
                        inputProcessor.Push(inputProcessor.Pop() & inputProcessor.Pop());
                        break;
                    case "|":
                        inputProcessor.Push(inputProcessor.Pop() | inputProcessor.Pop());
                        break;
                    case "^":
                        inputProcessor.Push(inputProcessor.Pop() ^ inputProcessor.Pop());
                        break;
                    default:
                        inputProcessor.Push(long.Parse(item));
                        break;
                }
            }
            Console.WriteLine(inputProcessor.Pop());
        }
    }
}
