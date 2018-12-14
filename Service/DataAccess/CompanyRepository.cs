using System.Collections.Generic;
using System.Data.SqlClient;
using Service.Model;


namespace Service.DataAccess
{
    internal class CompanyRepository
    {
        internal IEnumerable<Company> GetAllCompanies()
        {
            return null;    //todo
        }

        internal IEnumerable<CompanyType> GetCompanyTypes()
        {
            var companyTypes = new List<CompanyType>();

            string connString = "Server=localhost\\SCBN_MARMIHA;Database=METALOGIX;Trusted_Connection=True;";          //todo
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select [ID], [NAME] from [COMPANY_TYPE]", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            companyTypes.Add(new CompanyType { ID=reader.GetInt32(0), Name=reader.GetString(1) });
                        }
                    }
                }
            }

            return companyTypes;
        }
    }
}