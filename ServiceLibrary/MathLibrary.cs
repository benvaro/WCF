using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
//class library
namespace ServiceLibrary
{
    [ServiceContract]   // обов'язково - вказуємо що інтерфейс - то контракт
    public interface IMyMath
    {
        [OperationContract]    // - метод Add буде доступний всім, хто буде використовувати мій сервіс
        int Add(int a, int b);
    }

    public class MyMath : IMyMath
    {

        //Endpoint -- A-ddress B-inding C-ontract
        // http://127.0.0.1/MyServiceMath
        // Binding - BasicHttpBinding 
        // WSHttpBinding - автоматично кодуэ дані
        //netTcpBinding - тільки для.NET
        // netNamedPipedBinding
        /// <summary>
        /// Method for adding to numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            
            return a + b;
        }
    }
}




// InstallUtil /u MyServiceDemo.exe