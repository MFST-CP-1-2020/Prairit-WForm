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
            EmployeeDAL empdal1 = new EmployeeDAL();
            DataTable res=empdal1.GetDL();
            return res;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public int AddBL(EmployeeDTO empdto)
        {
            EmployeeDAL empdal2 = new EmployeeDAL();
            int result=empdal2.AddDL(empdto);
            return result;
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void DeleteBL(EmployeeDTO empdto)
        {
            EmployeeDAL empdal3 = new EmployeeDAL();
            empdal3.DeleteDL(empdto);
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void UpdateBL(EmployeeDTO empdto)
        {
            EmployeeDAL empdal4 = new EmployeeDAL();
            empdal4.UpdateDL(empdto);
        }
        #endregion
    }
}
