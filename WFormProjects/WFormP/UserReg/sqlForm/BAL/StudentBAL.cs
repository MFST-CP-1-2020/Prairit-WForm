﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BAL
{
    /// <summary>
    /// This class contains the properties of the Student 
    /// </summary>
    public class StudentBAL
    {
        #region "Properties"

        //SQLHelper helper = new SQLHelper();

        StudentDAL stddal = new StudentDAL();

        #endregion

        #region "Functions"

        /// <summary>
        /// This function will use SQLDataAdapter and return the DataTable
        /// </summary>
        public DataTable GetBL()
        {
            //DataTable res = helper.SqlDataAdapter(true, "DisplayRows");
            //return res;
            DataTable result=stddal.GetDL();
            return result;
        }

        /// <summary>
        /// This function will add rows in the SQL datatable
        /// </summary>
        public int AddBL(Student std)
        {
            //ParameterForInsert(stddto);
            //int result = helper.ExecuteScalar(true, "ScalarInsertRow");
            //return result;
            int result = stddal.AddDL(std);
            return result;
        }

        /// <summary>
        /// This function will delete the row at the desired StudentID
        /// </summary>
        public void DeleteBL(Student std)
        {
            //ParameterForDelete(stddto);
            //helper.ExecuteNonQuery(true, "DeleteRow");
            stddal.DeleteDL(std);
        }

        /// <summary>
        /// This function will update the entries in the SQL table to the inserted vales
        /// </summary>
        public void UpdateBL(Student std)
        {
            //ParameterForUpdate(stddto);
            //helper.ExecuteNonQuery(true, "UpdateRow");
            stddal.UpdateDL(std);
        }
        #endregion
    }
}