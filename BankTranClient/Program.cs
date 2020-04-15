using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BankTranClient.ServiceReference1;
namespace BankTranClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (BankServiceClient proxy = new BankServiceClient())
                {
                    double money;
                    do
                    {
                        Console.WriteLine("Enter money: ");
                        money = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            proxy.FillAccount(money);

                            Console.WriteLine("Account: " + proxy.GetBalance());

                        }
                        catch (CommunicationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    } while (money >= -1);
                }
                scope.Complete();
            }

        }
    }
}
