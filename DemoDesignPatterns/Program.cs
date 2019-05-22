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
            // you will get FileName property in fileLogger object at run time

            var databaseLogger = loggerFactory.CreateLogger(LoggerType.Database);
            databaseLogger.Log("Hi...");
            // you will get ConnectionString property in databaseLogger object at run time

            var consoleLogger = loggerFactory.CreateLogger(LoggerType.Console);
            consoleLogger.Log("Hi...");

            Console.ReadKey();
        }
    }
}
