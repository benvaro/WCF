using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankTranLib
{
    [ServiceContract]
    public interface IBankService
    {
        [OperationContract(IsOneWay = true)]
        void PutMoney(double money);
        [OperationContract]
        double GetBalance();
    }
  
}
