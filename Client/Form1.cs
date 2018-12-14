using System;
using System.Windows.Forms;

using Client.CompanyServiceReference;
using Client.DataAccess;


namespace Client
{
    public partial class Form1 : Form
    {
        private readonly CompanyDataClient _dataRepo = new CompanyDataClient(/*TODO*/"http://localhost:56417/CompanyService.svc");


        public Form1()
        {
            InitializeComponent();
            cbCompanyTypes.DataSource = _dataRepo.GetCompanyTypes();



            Load += OnLoad;

            
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            colCompanyName.DataPropertyName = "Name";
            colCountryCode.DataPropertyName = "CountryCode";
            colCompanyType.DataPropertyName = "Type.Name";


            gridResults.DataSource = new []
            {
                new Company { ID = 451024, Name = "Mikro carrot", CountryCode = "CZ", Type = new CompanyType { Name = "army!" } }
            };
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
