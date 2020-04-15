using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankTranLib
{
    [ServiceContract(SessionMode=SessionMode.Required)]  // 1) обовёязково підтримка сесій!
    public interface IBankService
    {
        [OperationContract]
        void FillAccount(double money);
        [OperationContract]
        double GetBalance();
    }

    [ServiceBehavior]
  //  [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class BankService : IBankService
    {
        double balance;
        static int id = 0;
        public BankService()
        {
            Console.WriteLine($"Account created {++id}");
        }
        //  [OperationBehavior(TransactionScopeRequired =true, TransactionAutoComplete = true)]

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]  // 2)
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public void FillAccount(double money)
        {
            Console.WriteLine("Fill account");
            if (money > 0)
                balance += money;
            
            Console.WriteLine("Balance = " + GetBalance());
            Console.WriteLine("Transaction ID: {0}", Transaction.Current.TransactionInformation.LocalIdentifier);
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
