using System;

namespace DemoDesignPatterns.Logger
{
    public class DatabaseLogger : ILogger
    {
        public string ConnectionString { get; set; }

        public void Log(string message)
        {
            Console.WriteLine("Database: " + message);
        }
    }
}
