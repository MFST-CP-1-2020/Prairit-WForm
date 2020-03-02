using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BAL;
using DTO;

namespace PAL
{
    /// <summary>
    /// This class defines the functionality of the form
    /// </summary>
    public partial class StudentForm : Form
    {
        #region"Properties"
        List <StudentDTO> ListDTO = new List<StudentDTO>();

        StudentBAL stdbal = new StudentBAL();

        StudentDTO stddto = new StudentDTO();
        #endregion

        #region "Functions"

        /// <summary>
        /// Constructor for initializing form components
        /// </summary>
        public StudentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event triggered on clicking the add button
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            stddto = ReadDataIntoStudent();
            int result=stdbal.AddBL(stddto);
            MessageBox.Show("Row inserted at row number:" + result);
            ClearEntriesInForm();
        }

        /// <summary>
        /// This function will bind the datagrid
        /// </summary>
        void BindGrid()
        {
            ListDTO = stdbal.GetBL();
            dataGridViewForSQL.DataSource = ListDTO;
        }

        /// <summary>
        /// This function will read data from winform and store it in StudentDTO object
        /// </summary>
        StudentDTO ReadDataIntoStudent()
        {
            stddto.FirstName = txtBoxFirstName.Text;
            stddto.LastName = txtBoxLastName.Text;
            try
            {
                stddto.StudentID = int.Parse(txtBoxID.Text);
            }
            catch (Exception) { }
            stddto.PhoneNumber = txtBoxPhoneNumber.Text;
            stddto.EmailID = txtBoxEmailID.Text;
            stddto.Gender= txtBoxGender.Text;
            stddto.State = txtBoxState.Text;
            stddto.Country = txtBoxCountry.Text;

            return stddto;
        }
        
        
        /// <summary>
        /// This function  is triggered upon clicking the delete button
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ReadDataIntoStudent();
            stdbal.DeleteBL(stddto);
            ClearEntriesInForm();
            MessageBox.Show("Row deleted");
        }

        /// <summary>
        /// This function is triggered upon clicking the load button
        /// </summary>
        private void Loadbutton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        /// <summary>
        /// This function is triggered upon clicking the update button
        /// </summary>
        private void updateButton_Click(object sender, EventArgs e)
        {
            ReadDataIntoStudent();
            stdbal.UpdateBL(stddto);
            ClearEntriesInForm();
            MessageBox.Show("Row updated successfully");
        }

        /// <summary>
        /// This function will reset the entries of the windows form
        /// </summary>
        private void ClearEntriesInForm()
        {
            txtBoxID.Clear();
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxEmailID.Clear();
            txtBoxGender.Clear();
            txtBoxCountry.Clear();
            txtBoxState.Clear();
        }

        #endregion
    }

}
