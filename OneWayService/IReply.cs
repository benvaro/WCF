using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OneWayService
{
    [ServiceContract]
    public interface IReply
    {
        [OperationContract]  // клієнт очікує відповідь --- запит-відповідь
        void SlowReply();

        [OperationContract(IsOneWay =true)]    // одностороння операція  // запит-без відповіді
        void FastReply();
    }

}
