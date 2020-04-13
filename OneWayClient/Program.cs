using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWayClient.ServiceReferenceOneWay;

namespace OneWayClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ReplyClient proxy = new ReplyClient())
            {
             //   proxy.SlowReply();
                proxy.FastReply();
                Console.WriteLine("ENter number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("User put number");
            }
        }
    }
}
