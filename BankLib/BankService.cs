using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BankLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] // один сервіс - на всіх
    public class BankService : IBankService
    {
        double balance;
        List<Client> callback = new List<Client>();
        static int id = 0;

        public BankService()
        {
            ++id;
            Console.WriteLine("Account created: " + id);

        }
        public double GetBalance()
        {
            //    callback.PrintInfo(OperationContext.Current.SessionId);
            return balance;
        }

        public void PutMoney(double money)
        {
            //      callback = OperationContext.Current.GetCallbackChannel<ICallback>();
            balance += money;
        }

        public bool IsLogIn(string name)
        {
            Client current = new Client()
            {
                callback = OperationContext.Current.GetCallbackChannel<ICallback>(),
                name = name
            };
            callback.Add(current);
            foreach (Client item in callback)
            {
                item.callback.PrintInfo("Logged: " + item.name);
            }
            return true;
        }
    }

    public class Client
    {
        public ICallback callback;
        public string name;
    }
}
