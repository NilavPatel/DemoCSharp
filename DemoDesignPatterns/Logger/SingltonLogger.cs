namespace DemoDesignPatterns.Logger
{
    public class SingltonLogger
    {
        private static SingltonLogger _instance = null;

        public ILoggerFactory logger = null;

        private SingltonLogger()
        {
            logger = new LoggerFactory();
        }

        public static SingltonLogger getInstance()
        {
            if (_instance == null)
            {
                _instance = new SingltonLogger();
            }
            return _instance;
        }
    }
}
