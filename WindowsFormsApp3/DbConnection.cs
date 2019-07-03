using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp3
{
    class DbConnection
    {
        private SqlConnection sqlconnection;
        public DbConnection() {
            sqlconnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Supun Randima\Desktop\ITP Testing\Recover win 3.3\WindowsFormsApp3\WindowsFormsApp3\Database\Backhoe.mdf;Integrated Security = True; Connect Timeout = 30");
        }
        public SqlConnection getDbConnection() {
            return sqlconnection;
        }

        public void closeConnection() {
            sqlconnection.Close();
        }

        public void startConnection() {
            sqlconnection.Open();
        }
    }
}
/*
 SqlConnection con = new SqlConnection(@"string link");
 SqlCommand com = new SqlCommand("select name from customer", con);
 SqlDataReader read = com.executeQuery();    
 foreach(sqlDataReader.read()){
 txt.addItems(sqlDatareader.getString());
    }
     
     
     
     
     */