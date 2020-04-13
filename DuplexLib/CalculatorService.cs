using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DuplexLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        ICalculatorCallback callback = null;
        double result = 0;
        public CalculatorService()
        {
            // встановлюємо зв'язок для доступу до каналу зворотнього зв'язку
            callback = OperationContext.Current.GetCallbackChannel<ICalculatorCallback>();
        }
        public void AddTo(double value)
        {
            result += value;
            callback.Equals(result);
        }

        public void ClearResult()
        {
            callback.Result(result);
            result = 0;
        }

        public void DivideBy(double value)
        {
            result /= value;
            callback.Equals(result);
        }

        public void MultiplyBy(double value)
        {
            result *= value;
            callback.Equals(result);
        }

        public void SubtructFrom(double value)
        {
            result -= value;
            callback.Equals(result);
        }
    }
}
