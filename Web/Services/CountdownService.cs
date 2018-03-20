using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public class CountdownService
    {
        private static string FILENAME = "Countdown.txt";

        public static int Get()
        {
            var filename = Path.Combine(Directory.GetCurrentDirectory(), FILENAME);

            var currentCountdown = File.Exists(filename) ? int.Parse(File.ReadAllLines(filename).Last()) : 5;

            // Lets blow up if reached countdown
            if (currentCountdown == 0)
            {
                throw new ApplicationException("I'm designed to do this");
            }

            Save(filename, currentCountdown -1);

            return currentCountdown;
        }

        private static void Save(string filename, int countdown)
        {
            if (File.Exists(filename))
            {
                Update(filename, countdown);
            }
            else
            {
                Create(filename, countdown);
            }
        }

        private static void Create(string filename, int countdown)
        {
            var output = File.CreateText(filename);
            output.WriteLine(countdown);
            output.Flush();
            output.Close();
        }

        private static void Update(string filename, int countdown)
        {
            var output = File.AppendText(filename);
            output.WriteLine(countdown);
            output.Flush();
            output.Close();
        }
    }
}
