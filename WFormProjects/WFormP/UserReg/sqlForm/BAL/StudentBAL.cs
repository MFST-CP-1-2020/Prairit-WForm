using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BAL
{
    /// <summary>
    /// This class contains the properties of the Student 
    /// </summary>
    public class StudentBAL
    {
        #region "Properties"
        /*
        public int StudentID { get; set; }
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
        public DataTable GetBL()
        {
            DataTable res = helper.SqlDataAdapter(true, "DisplayRows");
            return res;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public int AddBL(StudentDTO stddto)
        {

            ParameterForInsert(stddto);
            int result = helper.ExecuteScalar(true, "ScalarInsertRow");
            return result;
            //helper.parameters.Clear();

            //MessageBox.Show("Row inserted at index " + result.ToString());
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void DeleteBL(StudentDTO stddto)
        {
            ParameterForDelete(stddto);
            helper.ExecuteNonQuery(true, "DeleteRow");
            //helper.parameters.Clear();

            //MessageBox.Show("Row deleted successfully");
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void UpdateBL(StudentDTO stddto)
        {
            ParameterForUpdate(stddto);
            helper.ExecuteNonQuery(true, "UpdateRow");
            //helper.parameters.Clear();

            //MessageBox.Show("Row updated successfully");
        }

        /// <summary>
        /// This function will add the SQLParameters required for Insert stored procedure
        /// </summary>
        private void ParameterForInsert(StudentDTO stddto)
        {
            helper.AddParameter("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, stddto.firstName);
            helper.AddParameter("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, stddto.lastName);
            helper.AddParameter("@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, stddto.phoneNumber);
            helper.AddParameter("@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, stddto.emailID);
            helper.AddParameter("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, stddto.Gender);
            helper.AddParameter("@State", SqlDbType.NVarChar, ParameterDirection.Input, stddto.State);
            helper.AddParameter("@Country", SqlDbType.NVarChar, ParameterDirection.Input, stddto.Country);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Delete Stored Procedure
        /// </summary>
        private void ParameterForDelete(StudentDTO stddto)
        {
            helper.AddParameter("@StudentID", SqlDbType.Int, ParameterDirection.Input, stddto.StudentID);
        }

        /// <summary>
        /// This function will add the SQLParameter for the Update Stored Procedure
        /// </summary>
        private void ParameterForUpdate(StudentDTO stddto)
        {
            helper.AddParameter("@StudentID", SqlDbType.Int, ParameterDirection.Input, stddto.StudentID);
            helper.AddParameter("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, stddto.firstName);
            helper.AddParameter("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, stddto.lastName);
            helper.AddParameter("@PhoneNumber", SqlDbType.NVarChar, ParameterDirection.Input, stddto.phoneNumber);
            helper.AddParameter("@EmailID", SqlDbType.NVarChar, ParameterDirection.Input, stddto.emailID);
            helper.AddParameter("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, stddto.Gender);
            helper.AddParameter("@State", SqlDbType.NVarChar, ParameterDirection.Input, stddto.State);
            helper.AddParameter("@Country", SqlDbType.NVarChar, ParameterDirection.Input, stddto.Country);
        }


        #endregion
    }
}
