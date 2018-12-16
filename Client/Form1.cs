using System;
using System.Drawing;
using System.Windows.Forms;

using Client.DataAccess;
using Client.ViewModel;


namespace Client
{
    public partial class Form1 : Form
    {
        private readonly CompanyDataClient _dataRepo;


        internal Form1(CompanyDataClient dataClient)
        {
            _dataRepo = dataClient;
            InitializeComponent();
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            btnFind.Select();
            setPlaceholder(txtCompanyName);
            setPlaceholder(txtCompanyId);
            setPlaceholder(txtCountryCode);
            cbCompanyTypes.DataSource = _dataRepo.GetCompanyTypes();
            cbCompanyTypes.SelectedIndex = -1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int dummy;
            int id = int.TryParse(txtCompanyId.Text, out dummy) ? dummy : -1;
            string name = txtCompanyName.Font.Italic ? null : txtCompanyName.Text;
            string countryCode = txtCountryCode.Font.Italic ? null : txtCountryCode.Text;
            string type = ((CompanyTypeItem) cbCompanyTypes.SelectedValue)?.Text;

            gridResults.DataSource = _dataRepo.GetCompanies(id, name, countryCode, type);
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


        #region Textbox placeholders

        private void setPlaceholder(TextBox textbox)
        {
            textbox.Font = new Font(textbox.Font, FontStyle.Italic);
            textbox.ForeColor = Color.Gray;
            textbox.Text = textbox.Tag?.ToString();
        }

        private void resetPlaceholder(TextBox textbox)
        {
            textbox.ResetFont();
            textbox.ForeColor = SystemColors.WindowText;
            textbox.Text = null;
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox) sender;
            if (textbox.Font.Italic)
            {
                resetPlaceholder(textbox);
            }
        }

        private void textbox_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (String.IsNullOrEmpty(textbox.Text))
            {
                setPlaceholder(textbox);
            }
        }
        #endregion
    }
}
