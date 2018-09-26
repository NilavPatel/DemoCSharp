using System.ServiceProcess;

namespace DemoWindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MyDemoService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
