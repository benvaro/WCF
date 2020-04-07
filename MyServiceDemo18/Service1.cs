using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceDemo18
{
    public partial class MyServiceDemo : ServiceBase
    {
        public MyServiceDemo()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Logger("Service started.");
        }

        protected override void OnStop()
        {
            Logger("Service stopped.");
        }

        static void Logger(string message)
        {
            try
            {
                message += "\t\t" + DateTime.Now.ToLongTimeString() + "\n";
                File.AppendAllText("svclog.txt", message);
            }
            catch (Exception ex)
            {
                File.AppendAllText("error.txt", DateTime.Now.ToLongTimeString() + " " + ex.Message);
            }
        }
    }
}
