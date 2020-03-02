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
    /// This class contains the business logic for Data manipulation in the SQL table 
    /// </summary>
    public class StudentBAL
    {
        #region "Properties"
        
        StudentDAL stddal = new StudentDAL();

        StudentMapper mapper = new StudentMapper();

        #endregion

        #region "Functions"

        /// <summary>
        /// This function will have the business logic for displaying the data
        /// </summary>
        /// <returns>A list of StudentDTO objects</returns>
        public List<StudentDTO> GetBL()
        {
            List<Student> ListSTD=stddal.GetDL();
            List<StudentDTO> ListDTO=new List<StudentDTO>();
            foreach(var std in ListSTD)
            {
                ListDTO.Add(mapper.ToDtoObj(std));
            }
            return ListDTO;
        }

        /// <summary>
        /// This function will have the business logic for adding a row in SQL table
        /// </summary>
        /// <param name="stddto">A StudentDTO object with values to be added</param>
        /// <returns>Primary Key of the inserted row</returns>
        public int AddBL(StudentDTO stddto)
        {
            Student std=mapper.ToModelObj(stddto);
            int result = stddal.AddDL(std);
            return result;
        }

        /// <summary>
        /// This function will have the business logic for deleting the row in SQL table
        /// </summary>
        /// <param name="stddto">An object of the StudentDTO class with StudentID of the row to be deleted </param>
        public void DeleteBL(StudentDTO stddto)
        {
            Student std = mapper.ToModelObj(stddto);
            stddal.DeleteDL(std);
        }

        /// <summary>
        /// This function will have the business logic for updating the entries in the SQL table to the inserted vales
        /// </summary>
        /// <param name="stddto">A StudentDTO object with updated values</param>
        public void UpdateBL(StudentDTO stddto)
        {
            Student std=mapper.ToModelObj(stddto);
            stddal.UpdateDL(std);
        }
        #endregion
    }
}
