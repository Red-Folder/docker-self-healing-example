using System;
using System.IO;
using System.Linq;

namespace Healthcheck
{
    class Program
    {
        private static string FILENAME = "/app/Countdown.txt";
        static void Main(string[] args)
        {
            var currentCountdown = File.Exists(FILENAME) ? int.Parse(File.ReadAllLines(FILENAME).Last()) : 5;

            if (currentCountdown == 0)
            {
                Environment.Exit(1);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
