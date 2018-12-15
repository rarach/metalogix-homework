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
            return GetCompanies(-1, null, null, null);
        }

        internal IEnumerable<Company> GetCompanies(int id, string companyName, string countryCode, string type)
        {
            var companies = new List<Company>();

            var parameters = new List<SqlParameter>();
            string query = @"select c.[ID], c.[NAME], c.[COUNTRY_CODE], ct.[ID] as type_id, ct.[NAME] as type_name
                             from [COMPANY] c
                             inner join [COMPANY_TYPE] ct on c.[FK_COMPANY_TYPE]=ct.[ID]
                             where 1=1 ";
            //We either filter by company ID or by the other parameters
            if (id > 0)
            {
                query += "and c.[ID] = @companyId ";
                var param = new SqlParameter("companyId", SqlDbType.Int);
                param.Value = id;
                parameters.Add(param);
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(companyName))
                {
                    query += "and c.[NAME] like '%' + @companyName + '%' ";
                    var param = new SqlParameter("companyName", SqlDbType.NVarChar);
                    param.Value = companyName;
                    parameters.Add(param);
                }
                if (!String.IsNullOrWhiteSpace(countryCode))
                {
                    query += "and c.[COUNTRY_CODE] = @countryCode ";
                    var param = new SqlParameter("countryCode", SqlDbType.NVarChar);
                    param.Value = countryCode;
                    parameters.Add(param);
                }
                if (!String.IsNullOrWhiteSpace(type))
                {
                    query += "and ct.[NAME] = @typeName ";
                    var param = new SqlParameter("typeName", SqlDbType.NVarChar);
                    param.Value = type;
                    parameters.Add(param);
                }
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            companies.Add(new Company
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                CountryCode = reader.GetString(2),
                                Type = new CompanyType
                                {
                                    ID = reader.GetInt32(3),
                                    Name = reader.GetString(4)
                                }
                            });
                        }
                    }
                }
            }

            return companies;
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