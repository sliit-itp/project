using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace WindowsFormsApp3
{
    public partial class BookingUINew : UserControl
    {

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private DbSqlQuery dbSqlBooking = new DbSqlQuery();
        public BookingUINew()
        {
            try
            {
                InitializeComponent();
                //Establish db connection
                DbConnection dbConnection = new DbConnection();
                //open db connection
                dbConnection.startConnection();

                //String query
                String query = "select customerID From Bookings"; //set query

                //get sql connection
                sqlConnection = dbConnection.getDbConnection();

                //set sql command
                sqlCommand = dbSqlBooking.setSqlCommand(query, sqlConnection);

                //read data
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //add items to dropdownlist from db
                while (sqlDataReader.Read())
                {
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        dropDownBackhoeTypes1.AddItem(sqlDataReader.GetString(i));
                        dropDownBackhoeTypes2.AddItem(sqlDataReader.GetString(i));
                        dropDownBackhoeTypes3.AddItem(sqlDataReader.GetString(i));
                    }
                }
                String[] arr = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };
                foreach (String S in arr)
                {
                    dropDownNoOfBackhoes1.Items.Add(S);
                    dropDownNoOfBackhoes2.Items.Add(S);
                    dropDownNoOfBackhoes3.Items.Add(S);
                }
                //end add items to drop down

                //closing db connection
                dbConnection.closeConnection();
            }
            catch (Exception e) {
                MessageBox.Show("Error", e.Message , MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BookingUINew_Load(object sender, EventArgs e)
        {

        }

        private void dropDownBackhoeTypes1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void lblCallerName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
