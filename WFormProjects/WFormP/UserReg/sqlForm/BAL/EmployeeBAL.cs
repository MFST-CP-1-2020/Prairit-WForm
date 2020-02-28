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
    /// This class contains the properties of the Employee
    /// </summary>
    public class EmployeeBAL
    {
        #region "Properties"

        //SQLHelper helper = new SQLHelper();

        //EmployeeDAL empdal = new EmployeeDAL();

        #endregion

        #region "Functions"

        /// <summary>
        /// This function will use SQLDataAdapter and return the DataTable
        /// </summary>
        public DataTable GetBL()
        {
            EmployeeDAL empdal = new EmployeeDAL();
            DataTable res=empdal.GetDL();
            return res;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public int AddBL(Employee emp)
        {
            EmployeeDAL empdal = new EmployeeDAL();
            int result=empdal.AddDL(emp);
            return result;
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void DeleteBL(Employee emp)
        {
            EmployeeDAL empdal = new EmployeeDAL();
            empdal.DeleteDL(emp);
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void UpdateBL(Employee emp)
        {
            EmployeeDAL empdal = new EmployeeDAL();
            empdal.UpdateDL(emp);
        }
        #endregion
    }
}
