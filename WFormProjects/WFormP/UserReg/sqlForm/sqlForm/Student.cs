using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace sqlForm
{
    /// <summary>
    /// This class contains the properties of the Student 
    /// </summary>
    public class Student
    {
        #region "Properties"

        public int StudentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long phoneNumber { get; set; }
        public string emailID { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        SQLHelper helper = new SQLHelper();

        #endregion

        #region "Functions"

        /// <summary>
        /// This function will use SQLDataAdapter and return the DataTable
        /// </summary>
        public DataTable Get()
        {
            helper.CreateConnection();
            DataTable res = helper.SqlDataAdapter("DisplayRows");
            helper.CloseConnection();

            return res;
        }
        
        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public void Add()
        {
            helper.CreateConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            ParameterForInsert(command);
            int result=helper.ExecuteScalar(command,"ScalarInsertRow");

            
            MessageBox.Show("Row inserted at index "+result.ToString());
            helper.CloseConnection();
        }
        
        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void Delete()
        {
            helper.CreateConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            ParameterForDelete(command);
            helper.ExecuteNonQuery(command, "DeleteRow");

            helper.CloseConnection();
            MessageBox.Show("Row deleted successfully");
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void Update()
        {
            helper.CreateConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            ParameterForUpdate(command);
            helper.ExecuteNonQuery(command, "UpdateRow");

            helper.CloseConnection();
            MessageBox.Show("Row updated successfully");
        }       

        /// <summary>
        /// This function will add the SQLParameters required for Insert stored procedure
        /// </summary>
        private void ParameterForInsert(SqlCommand command)
        {
            helper.AddParameter(command, "@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, this.firstName);
            helper.AddParameter(command, "@LastName", SqlDbType.NVarChar, ParameterDirection.Input, this.lastName);
            helper.AddParameter(command, "@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, this.phoneNumber);
            helper.AddParameter(command, "@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, this.emailID);
            helper.AddParameter(command, "@Gender", SqlDbType.NVarChar, ParameterDirection.Input, this.Gender);
            helper.AddParameter(command, "@State", SqlDbType.NVarChar, ParameterDirection.Input, this.State);
            helper.AddParameter(command, "@Country", SqlDbType.NVarChar, ParameterDirection.Input, this.Country);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Delete Stored Procedure
        /// </summary>
        private void ParameterForDelete(SqlCommand command)
        {
            helper.AddParameter(command, "@StudentID", SqlDbType.Int, ParameterDirection.Input, this.StudentID);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Update Stored Procedure
        /// </summary>
        private void ParameterForUpdate(SqlCommand command)
        {
            helper.AddParameter(command, "@StudentID", SqlDbType.Int, ParameterDirection.Input, this.StudentID);
            helper.AddParameter(command, "@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, this.firstName);
            helper.AddParameter(command, "@LastName", SqlDbType.NVarChar, ParameterDirection.Input, this.lastName);
            helper.AddParameter(command, "@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, this.phoneNumber);
            helper.AddParameter(command, "@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, this.emailID);
            helper.AddParameter(command, "@Gender", SqlDbType.NVarChar, ParameterDirection.Input, this.Gender);
            helper.AddParameter(command, "@State", SqlDbType.NVarChar, ParameterDirection.Input, this.State);
            helper.AddParameter(command, "@Country", SqlDbType.NVarChar, ParameterDirection.Input, this.Country);
        }


        #endregion
    }
}
