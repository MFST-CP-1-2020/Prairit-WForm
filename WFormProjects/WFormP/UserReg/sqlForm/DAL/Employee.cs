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
    /// This class contains the properties of the Employee
    /// </summary>
    public class Employee
    {
        #region "Properties"

        public int EmployeeID { get; set; }
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
            DataTable res = helper.SqlDataAdapter(true, "EmployeeDisplayRows");
            return res;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public void Add()
        {

            ParameterForInsert();
            int result = helper.ExecuteScalar(true, "EmployeeScalarInsertRow");
            //helper.parameters.Clear();

            //MessageBox.Show("Row inserted at index " + result.ToString());
        }

        /// <summary>
        /// This function will delete the row at the desired EmployeeID
        /// </summary>
        public void Delete()
        {
            ParameterForDelete();
            helper.ExecuteNonQuery(true, "EmployeeDeleteRow");
            //helper.parameters.Clear();

            //MessageBox.Show("Row deleted successfully");
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void Update()
        {
            ParameterForUpdate();
            helper.ExecuteNonQuery(true, "EmployeeUpdateRow");
            //helper.parameters.Clear();

            //MessageBox.Show("Row updated successfully");
        }

        /// <summary>
        /// This function will add the SQLParameters required for Insert stored procedure
        /// </summary>
        private void ParameterForInsert()
        {
            helper.AddParameter("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, this.firstName);
            helper.AddParameter("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, this.lastName);
            helper.AddParameter("@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, this.phoneNumber);
            helper.AddParameter("@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, this.emailID);
            helper.AddParameter("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, this.Gender);
            helper.AddParameter("@State", SqlDbType.NVarChar, ParameterDirection.Input, this.State);
            helper.AddParameter("@Country", SqlDbType.NVarChar, ParameterDirection.Input, this.Country);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Delete Stored Procedure
        /// </summary>
        private void ParameterForDelete()
        {
            helper.AddParameter("@EmployeeID", SqlDbType.Int, ParameterDirection.Input, this.EmployeeID);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Update Stored Procedure
        /// </summary>
        private void ParameterForUpdate()
        {
            helper.AddParameter("@EmployeeID", SqlDbType.Int, ParameterDirection.Input, this.EmployeeID);
            helper.AddParameter("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, this.firstName);
            helper.AddParameter("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, this.lastName);
            helper.AddParameter("@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, this.phoneNumber);
            helper.AddParameter("@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, this.emailID);
            helper.AddParameter("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, this.Gender);
            helper.AddParameter("@State", SqlDbType.NVarChar, ParameterDirection.Input, this.State);
            helper.AddParameter("@Country", SqlDbType.NVarChar, ParameterDirection.Input, this.Country);
        }


        #endregion
    }
}
