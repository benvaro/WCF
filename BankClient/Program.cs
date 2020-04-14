using BankClient.ServiceReference1;
using System;
namespace BankClient
{
    class Program
    {
        class CallbackHandler : IBankServiceCallback
        {
            public void PrintInfo(string str)
            {
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            BankServiceClient proxy = new BankServiceClient(new System.ServiceModel.InstanceContext(new CallbackHandler()));
            Console.WriteLine("Enter name:");
            if (!proxy.IsLogIn(Console.ReadLine()))
                return;
            Console.WriteLine("Enter money:");
            double money = Convert.ToDouble(Console.ReadLine());
            while (money > 0)
            {
                proxy.PutMoney(money);
                Console.WriteLine("Balance: " + proxy.GetBalance());
                Console.WriteLine("Enter money:");
                money = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
