using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sqlForm
{ 
    /// <summary>
    /// This class helps in creating and closing connections as well as execute the stored procedures
    /// </summary>
    class SQLHelper
    {
        SqlConnection connection;
        string connectionString;

        /// <summary>
        /// Constructor to initialize the connection string
        /// </summary>
        public SQLHelper()
        {

            connectionString = @"Server=PRAIRIT-PC\SQLEXPRESS;Database=TestDB;User Id = sa; Password=mindfire@1";
        }

        /// <summary>
        /// This function establishes a connection to the SQL Server
        /// </summary>
        public void CreateConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Failed to create a connection");
            }
        }

        /// <summary>
        /// This function will close the connection with the SQL Server
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Failed to close the connection");
            }
        }

        /// <summary>
        /// This function will execute the Stored Procedure by using ExecuteNonQuery
        /// </summary>
        public void ExecuteNonQuery(SqlCommand command, string storedProcedure)
        {
            try
            {
                command.Connection = connection;
                command.CommandText = storedProcedure;
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Failed to execute NonQuery");
            }         
        }

        /// <summary>
        /// This function will execute the stored procedure by using ExecuteScalar
        /// </summary>
        public int ExecuteScalar(SqlCommand command, string commandString)
        {
            int id = new int();
            try
            {
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = CommandType.StoredProcedure;
                id = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("Failed to execute Scalar");
            }
            return id;
        }

        /// <summary>
        /// This function will use SQLAdapter to fill and return a datatable
        /// </summary>
        public DataTable SqlDataAdapter(string commandString)
        {

            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = commandString;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Failed to use SQLAdapter to fill the DataTable");
            }
            return dt;
        }
    }
}
