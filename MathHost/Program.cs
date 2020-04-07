using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MathHost
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Binding info
            //WSHttpBinding binding = new WSHttpBinding();
            //Console.WriteLine("Binding : {0} \n based on ", binding.GetType().Name);
            //BindingElementCollection elements = binding.CreateBindingElements();
            //foreach (var item in elements)
            //{
            //    Console.WriteLine("Base binding: {0}", item.GetType().Name);
            //} 
            #endregion
            ServiceHost host = new ServiceHost(typeof(MyMath));
            host.AddServiceEndpoint(typeof(IMyMath), new NetTcpBinding(), "http://127.0.0.1/MyMath");   //// endpoint: contract. binding, address
            host.Open();
            Console.WriteLine("Service works... Press enter to close");
            Console.ReadLine();
            host.Close();
        }
    }
}
