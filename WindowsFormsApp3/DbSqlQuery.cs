using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp3
{
    class DbSqlQuery
    {
        private SqlCommand sqlCommand;


        public SqlCommand setSqlCommand(String sqlQuery, SqlConnection sqlConnection)
        {
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            return sqlCommand;
        }

    }
}
