using BankTranLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankTranHost
{
    class BankHost
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(BankService)))
            {
                Console.Title = "Bank host";
                host.Open();
                Console.WriteLine("Host works");
                Console.ReadLine();
            }
        }
    }
}
