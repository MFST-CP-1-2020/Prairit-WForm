using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// This class helps in creating and closing connections as well as execute the stored procedures
    /// </summary>
    public class SQLHelper
    {
        #region "Properties"
        private string connectionString;

        List<SqlParameter> parameters;
        #endregion

        #region"Functions"
        /// <summary>
        /// Constructor to initialize the connection string
        /// </summary>
        public SQLHelper()
        {

            connectionString = @"Server=PRAIRIT-PC\SQLEXPRESS;Database=TestDB;User Id = sa; Password=mindfire@1";
            parameters = new List<SqlParameter>();
        }

        /// <summary>
        /// This function will execute the Stored Procedure by using ExecuteNonQuery
        /// </summary>
        public void ExecuteNonQuery(bool isProcedure, string storedProcedure)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = storedProcedure;
                    command.CommandType = isProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    command.Parameters.AddRange(parameters.ToArray());
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                        parameters.Clear();
                    }
                }

            }
            catch
            {
                //MessageBox.Show("Failed to execute NonQuery");
            }
        }

        /// <summary>
        /// This function will execute the stored procedure by using ExecuteScalar
        /// </summary>
        public int ExecuteScalar(bool isProcedure, string commandString)
        {
            int id = new int();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = commandString;
                    command.CommandType = isProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    command.Parameters.AddRange(parameters.ToArray());
                    id = Convert.ToInt32(command.ExecuteScalar());
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                        parameters.Clear();
                    }
                }

            }
            catch
            {
                //MessageBox.Show("Failed to execute Scalar");
            }
            return id;
        }

        /// <summary>
        /// This function will use SQLAdapter to fill and return a datatable
        /// </summary>
        public DataTable SqlDataAdapter(bool isProcedure, string commandString)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = commandString;
                    command.CommandType = isProcedure ? CommandType.StoredProcedure : CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                        parameters.Clear();
                    }
                }

            }
            catch
            {
                //MessageBox.Show("Failed to use SQLAdapter to fill the DataTable");
            }
            return dt;
        }

        /// <summary>
        /// This function will add the SQLParameters to the passes command object 
        /// </summary>
        public void AddParameter(string paramName, SqlDbType paramType, ParameterDirection direction, object value)
        {
            try
            {
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = paramName;
                parameter.SqlDbType = paramType;
                parameter.Direction = direction;
                parameter.Value = value;
                //command.Parameters.Add(parameter);
                parameters.Add(parameter);
            }
            catch
            {
                //MessageBox.Show("Failed to add parameters");
            }
        }
        #endregion
    }
}
