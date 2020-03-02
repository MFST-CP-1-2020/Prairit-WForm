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
using DTO;

namespace PAL
{

    /// <summary>
    /// This class defines the functionality of the form
    /// </summary>
    public partial class EmployeeForm : Form
    {
        #region"Properties"
        List<EmployeeDTO> ListDTO = new List<EmployeeDTO>();

        EmployeeBAL empbal = new EmployeeBAL();

        EmployeeDTO empdto = new EmployeeDTO();
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
            empdto = ReadDataIntoEmployee();
            int result =empbal.AddBL(empdto);
            MessageBox.Show("Row inserted with the following id: "+result);
            ClearEntriesInForm();
        }

        /// <summary>
        /// This function will update the datagrid
        /// </summary>
        void BindGrid()
        {
            ListDTO = empbal.GetBL();
            dataGridViewForSQL.DataSource = ListDTO;
        }

        /// <summary>
        /// This function will read data from winform and store it in the object
        /// </summary>
        EmployeeDTO ReadDataIntoEmployee()
        {
            empdto.FirstName = txtBoxFirstName.Text;
            empdto.LastName = txtBoxLastName.Text;
            try
            {
                empdto.EmployeeID = int.Parse(txtBoxID.Text);
            }
            catch (Exception) { }
            empdto.PhoneNumber = txtBoxPhoneNumber.Text;
            empdto.EmailID = txtBoxEmailID.Text;
            empdto.Gender = txtBoxGender.Text;
            empdto.State = txtBoxState.Text;
            empdto.Country = txtBoxCountry.Text;

            return empdto;
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
            empbal.DeleteBL(empdto);
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
            empbal.UpdateBL(empdto);
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
        /// <summary>
        /// This function will be triggered on form's loading
        /// </summary>
        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
        
    }
}
