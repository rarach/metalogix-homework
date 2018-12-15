using System;
using System.ComponentModel;
using System.Windows.Forms;

using Client.DataAccess;
using Client.ViewModel;


namespace Client
{
    public partial class Form1 : Form
    {
        private readonly CompanyDataClient _dataRepo;// = new CompanyDataClient(/*TODO*/"http://localhost:56417/CompanyService.svc");


        internal Form1(CompanyDataClient dataClient)
        {
            _dataRepo = dataClient;
            InitializeComponent();
            cbCompanyTypes.DataSource = _dataRepo.GetCompanyTypes();
            cbCompanyTypes.SelectedIndex = -1;



            Load += OnLoad;

            
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            gridResults.DataSource = _dataRepo.GetCompanies(123, null, null, null);
        }





        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            using (var modal = new NewCompanyDialog(_dataRepo))
            {
                modal.ShowDialog(this);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
