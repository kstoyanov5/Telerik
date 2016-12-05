using System;

namespace _5.SearchInBits
{
    class SearchInBits
    {
        static void Main(string[] args)
        {
            int coder = int.Parse(Console.ReadLine());
            int codeCount = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < codeCount; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());

                // pos is <= 26 because we search till the 30th bit and j == 4 so 26+4 positions = 30
                for (int pos = 0; pos <= 26; pos++)
                {
                    bool matcher = true;
                    for (int j = 0; j < 4; j++)
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
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
