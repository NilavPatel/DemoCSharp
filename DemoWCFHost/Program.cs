using DemoWCF.Abstract;
using DemoWCF.Concrete;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace DemoWCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost/DemoWCF/Employees.svc");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(EmployeeService), httpUrl);
            //Add a service endpoint
            host.AddServiceEndpoint(typeof(IEmployeeService), new BasicHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();

            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();
        }
    }
}
