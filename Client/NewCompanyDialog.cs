using System;
using System.Windows.Forms;

using Client.CompanyServiceReference;
using Client.DataAccess;
using Client.ViewModel;


namespace Client
{
    public partial class NewCompanyDialog : Form
    {
        private readonly CompanyDataClient _dataRepo;


        internal NewCompanyDialog(CompanyDataClient dataClient)
        {
            _dataRepo = dataClient;

            InitializeComponent();
            cbCompanyTypes.DataSource = _dataRepo.GetCompanyTypes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var newCompany = new Company
                {
                    Name = txtCompanyName.Text,
                    CountryCode = txtCountryCode.Text,
                    Type = new CompanyType {ID = ((CompanyTypeItem) cbCompanyTypes.SelectedItem).ID}
                };

                _dataRepo.CreateCompany(newCompany);
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private bool validate()
        {
            bool valid = true;
            lblError.Text = null;

            if (String.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                valid = false;
                lblError.Text = "Company name must be given";
            }
            if (String.IsNullOrWhiteSpace(txtCountryCode.Text))
            {
                if (!valid)
                {
                    lblError.Text += Environment.NewLine;
                }
                valid = false;
                lblError.Text += "Country code must be given";
            }

            return valid;
        }
    }
}
