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

namespace sqlForm
{
    /// <summary>
    /// This class defines the functionality of the form
    /// </summary>
    public partial class SQLDataForm : Form
    {
        #region"Properties"
        DataTable result = new DataTable();

        Student std = new Student();
        #endregion

        #region "Functions"

        /// <summary>
        /// Constructor for initializing form components
        /// </summary>
        public SQLDataForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event triggered on clicking the add button
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            //std = new Student();
            std = ReadDataIntoStudent();
            std.Add();
            ClearEntriesInForm();
        }

        /// <summary>
        /// This function will update the datagrid
        /// </summary>
        void BindGrid()
        {
            result = std.Get();
            dataGridViewForSQL.DataSource = result;
        }

        /// <summary>
        /// This function will read data from winform and store it in the object
        /// </summary>
        Student ReadDataIntoStudent()
        {
            //std = new Student();
            std.firstName = txtBoxFirstName.Text;
            std.lastName = txtBoxLastName.Text;
            try
            {
                std.StudentID = int.Parse(txtBoxID.Text);
                std.phoneNumber = long.Parse(txtBoxPhoneNumber.Text);
            }
            catch (Exception) { }
            std.emailID = txtBoxEmailID.Text;
            std.Gender= txtBoxGender.Text;
            std.State = txtBoxState.Text;
            std.Country = txtBoxCountry.Text;

            return std;
        }

        /// <summary>
        /// Event triggered on loading of the winform
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        /// <summary>
        /// This function  is triggered upon clicking the delete button
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ReadDataIntoStudent();
            std.Delete();
            ClearEntriesInForm();
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
            std.Update();
            ClearEntriesInForm();
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
