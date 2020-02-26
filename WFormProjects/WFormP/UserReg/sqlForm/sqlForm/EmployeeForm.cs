using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace PAL
{

    /// <summary>
    /// This class defines the functionality of the form
    /// </summary>
    public partial class EmployeeForm : Form
    {
        #region"Properties"
        DataTable result = new DataTable();

        Employee emp = new Employee();
        #endregion

        #region "Functions"

        /// <summary>
        /// Constructor for initializing form components
        /// </summary>
        public EmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event triggered on clicking the add button
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            //std = new Student();
            emp = ReadDataIntoEmployee();
            int result =emp.AddBL();
            MessageBox.Show("Row inserted with the following id:"+result);
            ClearEntriesInForm();
        }

        /// <summary>
        /// This function will update the datagrid
        /// </summary>
        void BindGrid()
        {
            result = emp.GetBL();
            dataGridViewForSQL.DataSource = result;
        }

        /// <summary>
        /// This function will read data from winform and store it in the object
        /// </summary>
        Employee ReadDataIntoEmployee()
        {
            //std = new Student();
            emp.firstName = txtBoxFirstName.Text;
            emp.lastName = txtBoxLastName.Text;
            try
            {
                emp.EmployeeID = int.Parse(txtBoxID.Text);
                emp.phoneNumber = long.Parse(txtBoxPhoneNumber.Text);
            }
            catch (Exception) { }
            emp.emailID = txtBoxEmailID.Text;
            emp.Gender = txtBoxGender.Text;
            emp.State = txtBoxState.Text;
            emp.Country = txtBoxCountry.Text;

            return emp;
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
            ReadDataIntoEmployee();
            emp.DeleteBL();
            ClearEntriesInForm();
            MessageBox.Show("Row deleted");
        }

        /// <summary>
        /// This function is triggered upon clicking the load button
        /// </summary>
        private void loadButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        /// <summary>
        /// This function is triggered upon clicking the update button
        /// </summary>
        private void updateButton_Click(object sender, EventArgs e)
        {
            ReadDataIntoEmployee();
            emp.UpdateBL();
            ClearEntriesInForm();
            MessageBox.Show("Row updated");
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

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
