using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TotalMathLib
{
    [ServiceContract]
    public interface IMath    // Контракт
    {
        [OperationContract]
        MathData Calculate(int x, int y);
    }
   
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        void AddStudent(Student st);
        [OperationContract]
        List<Student> GetStudents();
    }
    [DataContract]
    public class Student
    {
        [DataMember]
        string name;
        [DataMember]
        Address add;
    }
    public class Students : IStudent
    {
        List<Student> all = new List<Student>();

        public void AddStudent(Student st)
        {
            all.Add(st);
        }

        public List<Student> GetStudents()
        {
            return all;
        }
    }
    [DataContract]
    public class MathData   // struct may be   enum may be too
    {
        [DataMember]
        public int resAdd;
        [DataMember]
        public int resMult;
        [DataMember]
        public int resDiv;
        [DataMember]
        public int resSub;
    }
    //
    [DataContract]
    enum Gender
    {
        [EnumMember]
        Male,
        [EnumMember]
        Female,
        Undeterminate
    }
    [DataContract]
    class Address
    {
        [DataMember]
        string city;
        [DataMember]
        string street;
    }
   

    public class MathLib : IMath // Сервіс
    {
        public MathData Calculate(int x, int y)
        {
            MathData data = new MathData();
            data.resAdd = x + y;
            data.resSub = x - y;
            data.resMult = x * y;
            if (y != 0)
                data.resDiv = x / y;
            return data;
        }
    }
}
