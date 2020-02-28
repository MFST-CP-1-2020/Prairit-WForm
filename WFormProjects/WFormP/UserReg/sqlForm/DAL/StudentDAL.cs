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
    /// This class contains the properties of the Student 
    /// </summary>
    public class StudentDAL
    {
        #region "Properties"

        TestDBEntities context = new TestDBEntities();

        #endregion

        #region "Functions"
        

        /// <summary>
        /// This function will use SQLDataAdapter and return the DataTable
        /// </summary>
        public DataTable GetDL()
        {
            DataTable dt = addColumns();
            var dto = from d in context.Students select d;
            foreach(var rowobject in dto)
            {
                DataRow datarow = dt.NewRow();
                datarow["StudentID"] = rowobject.StudentID;
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
            dt.Columns.Add("StudentID");
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
        public int AddDL(Student std)
        {
            var dto=context.Students.Add(std);
            context.SaveChanges();
            return dto.StudentID;
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void DeleteDL(Student std)
        {
            var dto = (from d in context.Students where d.StudentID == std.StudentID select d).Single();
            context.Students.Remove(dto);
            context.SaveChanges();
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void UpdateDL(Student std)
        {
            Student dto = (from d in context.Students where d.StudentID == std.StudentID select d).Single();
            dto.StudentID = std.StudentID;
            dto.FirstName = std.FirstName;
            dto.LastName = std.LastName;
            dto.PhoneNumber = std.PhoneNumber;
            dto.EmailID = std.EmailID;
            dto.Gender = std.Gender;
            dto.State = std.State;
            dto.Country = std.Country;
            context.SaveChanges();

        }
        #endregion
    }
}
