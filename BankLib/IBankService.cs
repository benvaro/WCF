using System.ServiceModel;

namespace BankLib
{
    [ServiceContract(CallbackContract = typeof(ICallback))]
    public interface IBankService
    {
        [OperationContract(IsOneWay = true)]
        void PutMoney(double money);
        [OperationContract]
        double GetBalance();
        [OperationContract]
        bool IsLogIn(string name);
    }
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void PrintInfo(string str);
    }

}
