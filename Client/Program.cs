using System;
using System.Windows.Forms;
using Client.DataAccess;


namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(new CompanyDataClient(/*TODO*/"http://localhost:56417/CompanyService.svc")));
        }
    }
}
