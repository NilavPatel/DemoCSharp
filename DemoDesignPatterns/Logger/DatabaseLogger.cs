using System;

namespace DemoDesignPatterns.Logger
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Database: " + message);
        }
    }
}
