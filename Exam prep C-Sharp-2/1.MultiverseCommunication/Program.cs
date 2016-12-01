﻿using System;
using System.Collections.Generic;

namespace _1.MultiverseCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
            var input = Console.ReadLine();
            long decimalRepresentation = 0;

            for (int i = 0; i < input.Length; i+=3)
            {
                var digitIn13 = input.Substring(i, 3);
                var decimalValue = digits.IndexOf(digitIn13);

                decimalRepresentation *= 13;
                decimalRepresentation += decimalValue;
            }
            Console.WriteLine(decimalRepresentation);
        }
    }
}
