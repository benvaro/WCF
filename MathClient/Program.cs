using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathClient
{
    class Program
    {
        [ServiceContract]
        public interface IMyMath
        {
            [OperationContract]
            int Add(int a, int b);
            [OperationContract]
            int Div(int a, int b);
        }
        static void Main(string[] args)
        {
            ChannelFactory<IMyMath> factory = new ChannelFactory<IMyMath>(new NetTcpBinding(), new EndpointAddress("http://127.0.0.1/MyMath"));  // Канали - абстракція, шлях передачі повідомлень  . Транспортні  , протокольні
            IMyMath channel = factory.CreateChannel();
            int result = channel.Add(10, 30);
            Console.WriteLine("Result = " + result);
            Console.ReadLine();
            factory.Close();
        }
    }
}