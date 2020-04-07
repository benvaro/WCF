using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGameDemo.ServiceReference1;
namespace MyGameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // MEX - metadata exchange - point
            using (MyGameClient client = new MyGameClient())
            {
                Console.WriteLine("Put your question");
                string answer = client.GetAnswer(Console.ReadLine());
                Console.WriteLine(answer);
            }
        }
    }
}
