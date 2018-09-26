namespace DemoDesignPatterns.Logger
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(LoggerType type);
    }
}
