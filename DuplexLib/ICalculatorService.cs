using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DuplexLib
{
    [ServiceContract(CallbackContract =typeof(ICalculatorCallback))]
    public interface ICalculatorService
    {
        [OperationContract(IsOneWay = true)]  // запит - не очікую відповідь
        void AddTo(double value);
        [OperationContract(IsOneWay = true)]  // запит - не очікую відповідь
        void SubtructFrom(double value);
        [OperationContract(IsOneWay = true)]  // запит - не очікую відповідь
        void DivideBy(double value);
        [OperationContract(IsOneWay = true)]  // запит - не очікую відповідь
        void MultiplyBy(double value);
        [OperationContract]
        void ClearResult();
    }

    public interface ICalculatorCallback
    {
        [OperationContract(IsOneWay = true)]
        void Equals(double result);
        [OperationContract(IsOneWay = true)]
        void Result(double result);

    }

}
