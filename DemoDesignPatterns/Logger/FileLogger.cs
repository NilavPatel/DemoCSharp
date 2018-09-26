using System;

namespace DemoDesignPatterns.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}
