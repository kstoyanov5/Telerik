using System;


namespace _2.SpeedsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            uint C = uint.Parse(Console.ReadLine());

            uint bestLenght = 0;
            uint maxSpeed = 1600;
            uint bestSpeed = 0;

            uint currentSpeed = 0;

            for (int i = 0; i < C; i++)
            {
                uint speed = uint.Parse(Console.ReadLine());
                uint currentLenght = 0;

                if (maxSpeed >= speed)
                {
                    maxSpeed = speed;
                    currentLenght++;

                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestSpeed = currentSpeed;
                    }
                    if (currentLenght == bestLenght)
                    {
                        if (currentSpeed >= bestSpeed)
                        {
                            bestSpeed = currentSpeed;
                        }                       
                    }

                }
                else
                {
                    currentSpeed += speed;
                }
            }
            Console.WriteLine(currentSpeed + " currentSpeed");
            Console.WriteLine(bestSpeed + " bestSpeed");
            Console.WriteLine(bestLenght + " bestLenght");
            //Console.WriteLine(currentLenght + " currentLenght");
        }
    }
}
