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

        TestDBEntities context = new TestDBEntities();

        #endregion

        #region "Functions"


        /// <summary>
        /// This function will use SQLDataAdapter and return the DataTable
        /// </summary>
        public DataTable GetDL()
        {
            DataTable dt = addColumns();
            var dto = from d in context.Employees select d;
            foreach (var rowobject in dto)
            {
                DataRow datarow = dt.NewRow();
                datarow["EmployeeID"] = rowobject.EmployeeID;
                datarow["First Name"] = rowobject.FirstName;
                datarow["Last Name"] = rowobject.LastName;
                datarow["Phone Number"] = rowobject.PhoneNumber;
                datarow["Email ID"] = rowobject.EmailID;
                datarow["Gender"] = rowobject.Gender;
                datarow["State"] = rowobject.State;
                datarow["Country"] = rowobject.Country;
                dt.Rows.Add(datarow);
            }
            return dt;
        }
        /// <summary>
        /// This function create columns in a datatable and returns this data table
        /// </summary>
        /// <returns></returns>
        private DataTable addColumns()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Email ID");
            dt.Columns.Add("Gender");
            dt.Columns.Add("State");
            dt.Columns.Add("Country");
            return dt;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public int AddDL(Employee emp)
        {
            var dto = context.Employees.Add(emp);
            context.SaveChanges();
            return dto.EmployeeID;
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void DeleteDL(Employee emp)
        {
            var dto = (from d in context.Employees where d.EmployeeID == emp.EmployeeID select d).Single();
            context.Employees.Remove(dto);
            context.SaveChanges();
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void UpdateDL(Employee emp)
        {
            Employee dto = (from d in context.Employees where d.EmployeeID == emp.EmployeeID select d).Single();
            dto.EmployeeID = emp.EmployeeID;
            dto.FirstName = emp.FirstName;
            dto.LastName = emp.LastName;
            dto.PhoneNumber = emp.PhoneNumber;
            dto.EmailID = emp.EmailID;
            dto.Gender = emp.Gender;
            dto.State = emp.State;
            dto.Country = emp.Country;
            context.SaveChanges();
        }
        #endregion
    }
}
