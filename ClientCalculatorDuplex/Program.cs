using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ClientCalculatorDuplex.ServiceReference1;

namespace ClientCalculatorDuplex
{
    // Контракт зворотнього звёязку
    public class CallbackHandler : ICalculatorServiceCallback
    {
        public void Equals(double result)
        {
            Console.WriteLine("Result {0}", result);
        }

        public void Result(double result1)
        {
            File.AppendAllText("result.txt", "Result = " + result1.ToString());
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // об'єкт типу контракта зворотнього зв'язку
            ICalculatorServiceCallback callback = new CallbackHandler();
            // хостинг об'єктів типу контракта зворотнього зв'язку (будуємо середовище виконання)
            InstanceContext context = new InstanceContext(callback);
            CalculatorServiceClient proxy = new CalculatorServiceClient(context);
            //  CalculatorServiceClient proxy = new CalculatorServiceClient(new InstanceContext(new CallbackHandler()));

            proxy.AddTo(100);

            //proxy.Close();
            proxy.MultiplyBy(2);
            proxy.DivideBy(4);

            proxy.ClearResult();
            Console.ReadLine();
        }
    }
}
