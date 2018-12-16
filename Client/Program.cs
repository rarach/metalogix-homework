using System;
using System.Configuration;
using System.Windows.Forms;
using Client.DataAccess;


namespace Client
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DI
            string serviceUrl = ConfigurationManager.AppSettings["serviceURL"];
            Application.Run(new Form1(new CompanyDataClient(serviceUrl)));
        }
    }
}
