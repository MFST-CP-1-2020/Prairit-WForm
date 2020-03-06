using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BAL.Mapper
{
    /// <summary>
    /// This class contains the mapping between Student and StudentDTO
    /// </summary>
    class StudentMapper
    {
        /// <summary>
        /// This function converts a StudentDTO object to Student object 
        /// </summary>
        /// <param name="stddto">Object of Student class</param>
        /// <returns>Object of EmployeeDTO class</returns>
        public Student ToModelObj(StudentDTO stddto)
        {
            Student std = new Student();
            std.StudentID = stddto.StudentID;
            std.FirstName = stddto.FirstName;
            std.LastName = stddto.LastName;
            std.PhoneNumber = stddto.PhoneNumber;
            std.EmailID = stddto.EmailID;
            std.Gender = stddto.Gender;
            std.State = stddto.State;
            std.Country = stddto.Country;
            return std;

        }

        /// <summary>
        /// This function converts a  Student object to StudentDTO object
        /// </summary>
        /// <param name="std">Object of Student class</param>
        /// <returns>Object of Student class</returns>
        public StudentDTO ToDtoObj(Student std)
        {
            StudentDTO stddto = new StudentDTO();
            stddto.StudentID=std.StudentID;
            stddto.FirstName= std.FirstName;
            stddto.LastName= std.LastName;
            stddto.PhoneNumber= std.PhoneNumber;
            stddto.EmailID= std.EmailID;
            stddto.Gender= std.Gender;
            stddto.State= std.State;
            stddto.Country= std.Country;
            return stddto;

        }

    }
}
