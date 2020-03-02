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
    /// This class contains the mapping between EmployeeDTO and Employee
    /// </summary>
    class EmployeeMapper
    {
        /// <summary>
        /// This function converts a Employee object to EmployeeDTO object
        /// </summary>
        /// <param name="empdto">Object of EmployeeDTO</param>
        /// <returns>Object of Employee</returns>
        public Employee ToModelObj(EmployeeDTO empdto)
        {
            Employee emp = new Employee();
            emp.EmployeeID = empdto.EmployeeID;
            emp.FirstName = empdto.FirstName;
            emp.LastName = empdto.LastName;
            emp.PhoneNumber = empdto.PhoneNumber;
            emp.EmailID = empdto.EmailID;
            emp.Gender = empdto.Gender;
            emp.State = empdto.State;
            emp.Country = empdto.Country;
            return emp;

        }


        /// <summary>
        /// This function converts a EmployeeDTO object to Employee object 
        /// </summary>
        /// <param name="emp">Object of EmployeeDTO</param>
        /// <returns>Object of Employee</returns>
        public EmployeeDTO ToDtoObj(Employee emp)
        {
            EmployeeDTO empdto = new EmployeeDTO();
            empdto.EmployeeID = emp.EmployeeID;
            empdto.FirstName = emp.FirstName;
            empdto.LastName = emp.LastName;
            empdto.PhoneNumber = emp.PhoneNumber;
            empdto.EmailID = emp.EmailID;
            empdto.Gender = emp.Gender;
            empdto.State = emp.State;
            empdto.Country = emp.Country;
            return empdto;

        }
    }
}
