using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAsyncClient.ServiceReference1;
namespace StudentAsyncClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StudentClient sc = new StudentClient())
            {
                sc.AddStudent(new Student { name = "Ivan", add = new Address { city = "Rivne", street = "Soborna" } });
                sc.BeginGetStudents(GetCallback, sc);
             //   sc.GetStudentsAsync();

                Console.WriteLine("Main works....");
                Console.ReadLine();
            }
        }

        private static void GetCallback(IAsyncResult ar)
        {
            StudentClient sc = (ar.AsyncState as StudentClient);
            List<Student> students = sc.EndGetStudents(ar);
            foreach (var item in students)
            {
                Console.WriteLine(item.name + " " + item.add.city);
            }
        }
    }
}
