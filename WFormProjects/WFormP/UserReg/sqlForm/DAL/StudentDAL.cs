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
    /// This class  uses EF for CRUD operations 
    /// </summary>
    public class StudentDAL
    {

        #region "Functions"


        /// <summary>
        /// This function will retrieve a list of the student objects in the SQL table
        /// </summary>
        /// <returns>List of student objects</returns>
        public List<Student> GetDL()
        {
            List<Student> list;
            using (TestDBEntities context = new TestDBEntities())
            {
                list=context.Students.ToList();
            }
            return list;
        }

        /// <summary>
        /// This function will add rows in the SQL table
        /// </summary>
        /// <param name="std">Student object which contains data to be added</param>
        /// <returns>primary key of the inserted row</returns>
        public int AddDL(Student std)
        {
            int id;
            using (TestDBEntities context = new TestDBEntities())
            {
                var dto = context.Students.Add(std);
                context.SaveChanges();
                id = dto.StudentID;
            }
            return id;
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        /// <param name="std">Primary key of the row to be deleted</param>
        public void DeleteDL(Student std)
        {
            using (TestDBEntities context = new TestDBEntities())
            {
                context.Entry(std).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        /// <param name="std">Student object with updated values</param>
        public void UpdateDL(Student std)
        {
            using (TestDBEntities context = new TestDBEntities())
            {
                context.Entry(std).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion
    }
}
