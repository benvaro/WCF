using MyGameLib;
using System;
using System.ServiceModel;

namespace MyGameHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WCF Host Works");
            using (ServiceHost host = new ServiceHost(typeof(MyGame)))
            {
                host.Open();
                Console.WriteLine("Service is ready");
                ShowABC(host);
                Console.ReadLine();
            }
        }

        private static void ShowABC(ServiceHost host)
        {
            Console.WriteLine("Show info about host");
            foreach (var item in host.Description.Endpoints)
            {
                Console.WriteLine($"Address {item.Address}");
                Console.WriteLine($"Binding {item.Binding.Name}");
                Console.WriteLine($"Contract {item.Contract.Name}");
            }
        }
    }
}
