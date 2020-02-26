using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {

        #region "Properties"

        public int StudentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long phoneNumber { get; set; }
        public string emailID { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        #endregion
    }
}
