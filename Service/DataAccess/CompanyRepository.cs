using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Service.Model;


namespace Service.DataAccess
{
    internal class CompanyRepository
    {
        private readonly string _connectionString;


        internal CompanyRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        internal IEnumerable<Company> GetAllCompanies()
        {
            return null;    //todo
        }



        internal bool CreateCompany(Company company)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = @"insert into [COMPANY]([NAME], [COUNTRY_CODE], [FK_COMPANY_TYPE])
                                           values(@name, @countryCode, @companyTypeId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var param = new SqlParameter("name", SqlDbType.NVarChar);
                    param.Value = company.Name;
                    command.Parameters.Add(param);

                    param = new SqlParameter("countryCode", SqlDbType.NVarChar);
                    param.Value = company.CountryCode;
                    command.Parameters.Add(param);

                    param = new SqlParameter("companyTypeId", SqlDbType.Int);
                    param.Value = company.Type.ID;
                    command.Parameters.Add(param);

                    int affected = command.ExecuteNonQuery();
                    return affected == 1;   //Note: in more elaborate system we'd probably want to return ID of the new company
                }
            }
        }

        internal IEnumerable<CompanyType> GetCompanyTypes()
        {
            var companyTypes = new List<CompanyType>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
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