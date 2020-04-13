using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryTest
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract(Name ="IntAdd")]
        int Add(int x, int y);
        [OperationContract(Name ="DoubleAdd")]
        double Add(double x, double y);
    }
}
