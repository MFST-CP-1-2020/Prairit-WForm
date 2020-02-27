using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    /// <summary>
    /// This class contains the properties of the Employee
    /// </summary>
    public class EmployeeDAL
    {
        #region "Properties"
        /*
        public int EmployeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long phoneNumber { get; set; }
        public string emailID { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string Country { get; set; }*/

        SQLHelper helper = new SQLHelper();
        

        #endregion

        #region "Functions"

        /// <summary>
        /// This function will use SQLDataAdapter and return the DataTable
        /// </summary>
        public DataTable GetDL()
        {
            DataTable res = helper.SqlDataAdapter(true, "EmployeeDisplayRows");
            return res;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public int AddDL(EmployeeDTO empdto)
        {

            ParameterForInsert(empdto);
            int result = helper.ExecuteScalar(true, "EmployeeScalarInsertRow");
            return result;
            

            //helper.parameters.Clear();

            //MessageBox.Show("Row inserted at index " + result.ToString());
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void DeleteDL(EmployeeDTO empdto)
        {
            ParameterForDelete(empdto);
            helper.ExecuteNonQuery(true, "EmployeeDeleteRow");
            //helper.parameters.Clear();

            //MessageBox.Show("Row deleted successfully");
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void UpdateDL(EmployeeDTO empdto)
        {
            ParameterForUpdate(empdto);
            helper.ExecuteNonQuery(true, "EmployeeUpdateRow");
            //helper.parameters.Clear();

            //MessageBox.Show("Row updated successfully");
        }

        /// <summary>
        /// This function will add the SQLParameters required for Insert stored procedure
        /// </summary>
        private void ParameterForInsert(EmployeeDTO empdto)
        {
            helper.AddParameter("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, empdto.firstName);
            helper.AddParameter("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, empdto.lastName);
            helper.AddParameter("@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, empdto.phoneNumber);
            helper.AddParameter("@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, empdto.emailID);
            helper.AddParameter("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, empdto.Gender);
            helper.AddParameter("@State", SqlDbType.NVarChar, ParameterDirection.Input, empdto.State);
            helper.AddParameter("@Country", SqlDbType.NVarChar, ParameterDirection.Input, empdto.Country);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Delete Stored Procedure
        /// </summary>
        private void ParameterForDelete(EmployeeDTO empdto)
        {
            helper.AddParameter("@EmployeeID", SqlDbType.Int, ParameterDirection.Input, empdto.EmployeeID);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Update Stored Procedure
        /// </summary>
        private void ParameterForUpdate(EmployeeDTO empdto)
        {
            helper.AddParameter("@EmployeeID", SqlDbType.Int, ParameterDirection.Input, empdto.EmployeeID);
            helper.AddParameter("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, empdto.firstName);
            helper.AddParameter("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, empdto.lastName);
            helper.AddParameter("@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, empdto.phoneNumber);
            helper.AddParameter("@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, empdto.emailID);
            helper.AddParameter("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, empdto.Gender);
            helper.AddParameter("@State", SqlDbType.NVarChar, ParameterDirection.Input, empdto.State);
            helper.AddParameter("@Country", SqlDbType.NVarChar, ParameterDirection.Input, empdto.Country);
        }


        #endregion
    }
}
