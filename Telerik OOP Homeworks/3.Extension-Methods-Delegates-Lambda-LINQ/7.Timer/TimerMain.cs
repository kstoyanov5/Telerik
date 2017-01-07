namespace _7.Timer
{
    using System;

    class TimerMain
    {
        public delegate void TimeDelegate();

        static void Main()
        {
            TimeDelegate timeDelegate = Print;
            timeDelegate();
        }

        public static void Print()
        {
            int currentSeconds = DateTime.Now.Second;
            int counter = 0;

            while (counter < 10)
            {
                int secondsAfter10Secs = DateTime.Now.Second;
                if (secondsAfter10Secs != currentSeconds)
                {
                    Console.WriteLine("Hello, time is your friend. Use it wisely.");
                    currentSeconds = secondsAfter10Secs;
                    counter++;
                }
            }
        }
    }
}
