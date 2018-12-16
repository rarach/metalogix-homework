using System;
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
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            cbCompanyTypes.DataSource = _dataRepo.GetCompanyTypes();
            cbCompanyTypes.SelectedIndex = -1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int dummy;
            int id = int.TryParse(txtCompanyId.Text, out dummy) ? dummy : -1;
            string type = ((CompanyTypeItem) cbCompanyTypes.SelectedValue)?.Text;
            gridResults.DataSource = _dataRepo.GetCompanies(id, txtCompanyName.Text, txtCountryCode.Text, type);
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
