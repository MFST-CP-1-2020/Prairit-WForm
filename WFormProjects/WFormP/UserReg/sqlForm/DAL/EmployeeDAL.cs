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
    /// This class interacts with the database and perform the desired CRUD operations
    /// </summary>
    public class EmployeeDAL
    {

        #region "Functions"

        /// <summary>
        /// This function will get the list of employees from the SQL table
        /// </summary>
        /// <returns>List of student objects</returns>
        public List<Employee> GetDL()
        {
            List<Employee> list;
            using (TestDBEntities context = new TestDBEntities())
            {
                list = context.Employees.ToList();
            }
            return list;
        }

        /// <summary>
        /// This function will add rows in the SQL table
        /// </summary>
        /// <param name="emp">Object with values of the row to be added</param>
        /// <returns>Primary key of the inserted row</returns>
        public int AddDL(Employee emp)
        {
            int id;
            using (TestDBEntities context = new TestDBEntities())
            {
                var dto = context.Employees.Add(emp);
                context.SaveChanges();
                id = dto.EmployeeID;
            }
            return id;
        }

        /// <summary>
        /// This function will delete the row at the desired EmployeeID
        /// </summary>
        /// <param name="emp">Object with primary key of the row to be deleted</param>
        public void DeleteDL(Employee emp)
        {
            using (TestDBEntities context = new TestDBEntities())
            {
                context.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted values
        /// </summary>
        /// <param name="emp">Object with updated values of the column in Employee object</param>
        public void UpdateDL(Employee emp)
        {
            using (TestDBEntities context = new TestDBEntities())
            {
                context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion
    }
}
