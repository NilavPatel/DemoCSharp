namespace DemoDesignPatterns.Logger
{
    public enum LoggerType
    {
        File,
        Database,
        Console
    }

    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(LoggerType type)
        {
            switch (type)
            {
                case LoggerType.File:
                    return new FileLogger();
                case LoggerType.Database:
                    return new DatabaseLogger();
                case LoggerType.Console:
                    return new ConsoleLogger();
                default:
                    return new FileLogger();
            }
        }
    }
}
