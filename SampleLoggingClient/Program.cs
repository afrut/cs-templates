using System;
using NLog;

namespace SampleLoggingClient
{
    class Program
    {
        private static readonly Logger logger = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Random random = new Random();
            int prev = -1;
            while(true)
            {
                logger.Info($"Previous random number was {prev}");
                int num = random.Next(1, 10);
                logger.Info($"Random number is {num}");
                logger.Info(String.Format("Sum of current and previous random numbers is {0}", num + prev));
                prev = num;
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}