using BankLib;
using System;
using System.ServiceModel;

namespace BankHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BankService)))
            {
                host.Open();
                Console.WriteLine("Host works...");
                Console.ReadLine();
            }
        }
    }
}
