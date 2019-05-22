using System;

namespace DemoDesignPatterns.Logger
{
    public class FileLogger : ILogger
    {
        public string FileName { get; set; }

        public void Log(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}
