using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace School.Data.Repositories
{
    internal class RepositoryBase
    {
        internal const string CONNECTIONSTRING_DB_KEY = "ConnectionString";

        private IDbConnection connection;
        internal IDbConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        public RepositoryBase(IConfigurationRoot configuration)
        {
            var connectionString = configuration.GetSection(CONNECTIONSTRING_DB_KEY);
            if (string.IsNullOrWhiteSpace(connectionString.Value))
                throw new ArgumentNullException("DB Connection string not found");

            Connection = new SqlConnection(connectionString.Value);
        }
    }
}
