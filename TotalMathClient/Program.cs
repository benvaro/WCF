using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalMathClient.ServiceReference1;
using TotalMathClient.ServiceReference2;
namespace TotalMathClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Test MathClient
            //using (MathClient proxy = new MathClient())
            //{
            //    MathData data = proxy.Calculate(15, 3);
            //    Console.WriteLine($"+ {data.resAdd}");
            //    Console.WriteLine($"- {data.resSub}");
            //    Console.WriteLine($"* {data.resMult}");
            //    Console.WriteLine($"/ {data.resDiv}");


            //} 
            #endregion
            #region Test StudentClient
            using (StudentClient client = new StudentClient())
            {
                Student[] arr = client.GetStudents();
                //....
                var stud = await client.GetStudentsAsync();
            } 
            #endregion

        }
    }
}
