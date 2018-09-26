using DemoDesignPatterns.Logger;
using System;

namespace DemoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = SingltonLogger.getInstance().logger;

            var fileLogger = loggerFactory.CreateLogger(LoggerType.File);
            fileLogger.Log("Hi...");

            var databaseLogger = loggerFactory.CreateLogger(LoggerType.Database);
            databaseLogger.Log("Hi...");

            var consoleLogger = loggerFactory.CreateLogger(LoggerType.Console);
            consoleLogger.Log("Hi...");

            Console.ReadKey();
        }
    }
}
