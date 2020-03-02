using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
using BAL.Mapper;

namespace BAL
{
    /// <summary>
    /// This class contains the busniess logic for data manipulation in SQL table
    /// </summary>
    public class EmployeeBAL
    {
        #region "Properties"
       
        EmployeeDAL empdal = new EmployeeDAL();

        EmployeeMapper mapper = new EmployeeMapper();

        #endregion

        #region "Functions"

        /// <summary>
        /// This function will use SQLDataAdapter and return the DataTable
        /// </summary>
        /// <returns>A list of EmployeeDTO objects</returns>
        public List<EmployeeDTO> GetBL()
        {
            List<Employee> ListEMP=empdal.GetDL();
            List<EmployeeDTO> ListDTO = new List<EmployeeDTO>();
            foreach(var employee in ListEMP)
            {
                ListDTO.Add(mapper.ToDtoObj(employee));
            }
            return ListDTO;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        /// <param name="empdto">Object if EmployeeDTO object</param>
        /// <returns>Primary key of the inserted row</returns>
        public int AddBL(EmployeeDTO empdto)
        {
            Employee emp = mapper.ToModelObj(empdto);
            int result=empdal.AddDL(emp);
            return result;
        }

        /// <summary>
        /// This function will delete the row at the desired EmployeeID
        /// </summary>
        /// <param name="empdto">EmployeeDTO object with EmployeeID</param>
        public void DeleteBL(EmployeeDTO empdto)
        {
            Employee emp = mapper.ToModelObj(empdto);
            empdal.DeleteDL(emp);
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        /// <param name="empdto">Object of EmployeeDTO with updated values</param>
        public void UpdateBL(EmployeeDTO empdto)
        {
            Employee emp = mapper.ToModelObj(empdto);
            empdal.UpdateDL(emp);
        }
        #endregion
    }
}
