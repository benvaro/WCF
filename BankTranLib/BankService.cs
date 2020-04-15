using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankTranLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] // один сервіс - на всіх
    public class BankService : IBankService
    {
        double balance;
       
        static int id = 0;

        public BankService()
        {
            ++id;
            Console.WriteLine("Account created: " + id);

        }
        public double GetBalance()
        {
            return balance;
        }

        public void PutMoney(double money)
        {
            balance += money;
        }

       
    }
}
