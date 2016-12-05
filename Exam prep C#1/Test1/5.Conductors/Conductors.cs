using System;
using System.Collections.Generic;


namespace _5.Conductors
{
    class Conductors
    {
        static void Main(string[] args)
        {
            int coder = int.Parse(Console.ReadLine());
            int codeCount = int.Parse(Console.ReadLine());
            string coderStr = Convert.ToString(coder, 2);

            List<string> output = new List<string>();

            for (int i = 0; i < codeCount; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                string pStr = Convert.ToString(inputNum, 2);

                for (int pos = 0; pos <= 32; pos++)
                {
                    bool matcher = true;
                    for (int j = 0; j < coderStr.Length; j++)
                    {
                        var posInNum = pos + j;
                        var posInCoder = j;

                        //Otkriva bit v opredelenata poziciq
                        var bitInNum = (inputNum & (1 << posInNum)) >> posInNum;
                        var bitInCoder = (coder & (1 << posInCoder)) >> posInCoder;

                        // Ako ima razlika mejdu bitovete, loopa spira i po4va sus sledva6tata poziciq na input numbera
                        if (bitInNum != bitInCoder)
                        {
                            matcher = false;
                            break;
                        }
                    }

                    if (matcher)
                    {
                        for (int k = 0; k < coderStr.Length; k++)
                        {
                            // Slagame pos + k ,za6toto iskame da smenim poziciqta na blokovete ot bitove
                            // v opredelenata poziciq input numbera
                            inputNum = inputNum & ~((1) << (pos + k));
                        }
                    }
                }
                output.Add(inputNum.ToString());
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
