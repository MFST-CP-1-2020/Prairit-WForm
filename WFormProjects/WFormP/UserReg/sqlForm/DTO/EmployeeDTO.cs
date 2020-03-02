using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// This is the Data Transfer Object class which stores the properties of an object of a employee table
    /// </summary>
    public class EmployeeDTO
    {

        #region "Properties"

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailID { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        

        #endregion
    }
}
