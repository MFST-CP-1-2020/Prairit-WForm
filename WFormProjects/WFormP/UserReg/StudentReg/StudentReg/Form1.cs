using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentReg
{
    public partial class Form1 : Form
    {
        DataTable user = new DataTable();//user's datatable

        DataTable state = new DataTable();//state's datatable

        DataTable country = new DataTable();//country's datatable

        int rowIndex, columnIndex;
        
        /*constructor to initialize the windows form*/
        public Form1()
        {
            InitializeComponent();
        }

        /*
          this function will be called upon submit button click     
             */

        private void button1_Click(object sender, EventArgs e)
        {
            bindGrid();//this function call will bind the grid
            clearEntries();//this function call will reset the values of the fields in form
            state.Clear();//emptying the datatable of state

        }

        /*this function will bind the data grid view with the datatable of user
         */
        void bindGrid()
        {

            DataRow row = user.NewRow();//new row is added for insertion into datatable

            row["Name"] = nameBox.Text;//reading data from data fields
            row["Country"] = countryBox.Text;//reading data from data fields
            row["State"] = stateBox.Text;//reading data from data fields
            try//handling of exception for an incorrect input
            {
                row["PhoneNumber"] = numberBox.Text;
            }
            catch(Exception)
            {
                MessageBox.Show("Number should be an integer");
            }

            row["Gender"] = getRadioValue();//getting the value of the radio button

            user.Rows.Add(row);//adding the row to the user datatable

            dataGridView1.DataSource = user;//binding the datatable to the 

            addLoadButton();//load button will be added to the grid

            addDeleteButton();//delete button will be added to the grid
            
        }
        /*this function will create a new column for load button*/
        void addLoadButton()
        {            
            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();//new datagrid buttoncolumn is defined
            ButtonColumn.Name = "Load column";//attributes of the button are set
            ButtonColumn.Text = "Load";//attributes of the button are set
            ButtonColumn.UseColumnTextForButtonValue = true;//display name of button
            //int columnIndex = 0;//
            if (dataGridView1.Columns["Load column"] == null)//checking if the column already exists
            {
                dataGridView1.Columns.Insert(0, ButtonColumn);//inserting the column
            }
        }

        /*this function will create a new column for delete button*/
        void addDeleteButton()
        {
            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();//new datagrid buttoncolumn is defined
            ButtonColumn.Name = "Delete column";//attributes of the button are set
            ButtonColumn.Text = "Delete";//attributes of the button are set
            ButtonColumn.UseColumnTextForButtonValue = true;//display name of button
            //int columnIndex = 0;
            if (dataGridView1.Columns["Delete column"] == null)//checking if the column already exists
            {
                dataGridView1.Columns.Insert(0, ButtonColumn);//inserting the column
            }
        }

        /*this function will empty the data values of the inputs*/
        void clearEntries()
        {
            nameBox.Text = "";//reseting the field value
            numberBox.Text = "";//reseting the field value
            countryBox.Text = "";//reseting the field value
            stateBox.Text = "";//reseting the field value
            maleButton.Checked = true;//reseting the field value
        }

        /*this function will get the values from the radiobuttons and convert to string*/
        string getRadioValue()
        {
            string value;
            bool isChecked = maleButton.Checked;//reading the bool value from radiobutton
            if (isChecked)//setting the value of the string if con
                value = maleButton.Text;
            else//setting the value of the string if condition is satisfied
                value = femaleButton.Text;
            return value;
        }

        /*this function will be called upon the form's loading*/
        private void Form1_Load(object sender, EventArgs e)
        {
            bindControls();
            clearEntries();
        }

        /*this function will bind the combobox as well as create the data grid view*/
        void bindControls()
        {
            bindComboBox();
            createGrid();
        }

        /*this function will bind the countries to the combobox*/
        void bindComboBox()
        {
            //bindState();
            addColumnsToState();
            bindCountry();
        }

        /*this function will create a new column for load button*/
        void createGrid()
        {
            user.Columns.Add("Name", typeof(string));//adding columns to the user datatable
            user.Columns.Add("Gender", typeof(string));//adding columns to the user datatable
            user.Columns.Add("PhoneNumber", typeof(int));//adding columns to the user datatable
            user.Columns.Add("Country", typeof(string));//adding columns to the user datatable
            user.Columns.Add("State", typeof(string));//adding columns to the user datatable
        }

        /*this function bind the states to the combobox*/
        void bindState()
        {
            state.Clear();//data entries in the datatable are cleared
            getState();

            /*
            DataRow stateRow = state.NewRow();

            stateRow["id"] = 1;
            stateRow["Name"] = "Uttar Pradesh";
            state.Rows.Add(stateRow);
            stateRow["id"] = 2;
            stateRow["Name"] = "Haryana";
            state.Rows.Add(stateRow);
            stateRow["id"] = 3;
            stateRow["Name"] = "Punjab";
            state.Rows.Add(stateRow);
            stateRow["id"] = 4;
            stateRow["Name"] = "Karnataka";
            state.Rows.Add(stateRow);*/

            stateBox.DisplayMember = "Name";//setting the display members of state's combobox
            stateBox.ValueMember = "id";//setting the value members of state's combobox
            stateBox.DataSource = state;//binding the state combobox to the datasource


        }

        /*this function will add the states to the state datatable*/
        void getState()
        {
            //addColumnsToState();
            int index = countryBox.SelectedIndex;//reading the selected index
            switch (index)//switching on the value of index
            {
                case 0: state.Rows.Add(1, "Uttar Pradesh");//if the selected option is india
                        state.Rows.Add(2, "Haryana");
                        state.Rows.Add(3, "Punjab");
                        state.Rows.Add(4, "Karnataka");
                    break;
                case 1:
                    state.Rows.Add(1, "Bumthang");//if the selected option is bhutan
                    state.Rows.Add(2, "Trongsa");
                    state.Rows.Add(3, "Punakha");
                    state.Rows.Add(4, "Thimphu");
                    break;
                case 2:
                    state.Rows.Add(1, "Uarun Kshetra");//if the selected option is nepal
                    state.Rows.Add(2, "Janakpur Kshetra");
                    state.Rows.Add(3, "Kathmandu Kshetra");
                    state.Rows.Add(4, "Gandak Kshetra");
                    break;
                case 3:
                    state.Rows.Add(1, "Kachin");//if the selected option is myanmar
                    state.Rows.Add(2, "Kayah");
                    state.Rows.Add(3, "Kayin");
                    state.Rows.Add(4, "Chin");
                    break;
            }
        }
        /*this function will be called at form's loading to add columns to the state datatable*/
        void addColumnsToState()
        {
                state.Columns.Add("id", typeof(int));
                state.Columns.Add("Name", typeof(string));
        }

        /*this function will bind the country datatable to the combobox*/
        void bindCountry()
        {
            getCountry();
            
            /*
            DataRow countryRow = country.NewRow();
            
            countryRow["id"] = 1;
            countryRow["Name"]= "India";
            country.Rows.Add(countryRow);
            countryRow["id"] = 2;
            countryRow["Name"] ="Bhutan";
            country.Rows.Add(countryRow);
            countryRow["id"]= 3;
            countryRow["Name"] = "Nepal";
            country.Rows.Add(countryRow);
            countryRow["id"] = 4;
            countryRow["Name"] = "Myanmar";
            country.Rows.Add(countryRow);*/

            countryBox.DisplayMember = "Name";//setting the display members of the country combobox
            countryBox.ValueMember = "id";//setting the value members of the country combobox
            countryBox.DataSource = country;//binding the datasource of countrybox to country
            
        }

        /*this function will add the names of the countries to the datatable*/
        void getCountry()
        {
            country.Columns.Add("id", typeof(int));//adding columns to the datatable of the country
            country.Columns.Add("Name", typeof(string));//adding columns to the datatable of the country

            country.Rows.Add(1, "India");//adding countries to the state datatable
            country.Rows.Add(2, "Bhutan");
            country.Rows.Add(3, "Nepal");
            country.Rows.Add(4, "Myanmar");

        }

        /*this function will be triggered when a cell is clicked*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            rowIndex = e.RowIndex;//store the row index of the clicked cell
            columnIndex = e.ColumnIndex;//store the column index of the clicked cell

            DataGridViewRow row = dataGridView1.Rows[rowIndex];//the row is accessed to read values
            if (columnIndex == 1)//if the load button is clicked
            {
                nameBox.Text = row.Cells["Name"].Value.ToString();//setting the values to data fields
                numberBox.Text = row.Cells["PhoneNumber"].Value.ToString();//setting the values to data fields
                stateBox.Text = row.Cells["State"].Value.ToString();//setting the values to data fields
                countryBox.Text = row.Cells["Country"].Value.ToString();//setting the values to data fields

                if (row.Cells["Gender"].Value.ToString()=="Male")//conditions for setting the values of radiobuttons 
                {
                    maleButton.Checked = true;
                }
                else
                {
                    femaleButton.Checked = true;
                }

                updateButton.Enabled = true;//enabling the update button
                bindState();//calling the function to bind states when load button is clicked
            }

            else if(columnIndex == 0)//if the delete button is clicked
            {
                dataGridView1.Rows.RemoveAt(rowIndex);//delete the current rowdataGridView1.CurrentRow.Index
            }
        }
        
        /*this function will be triggered when a a value in the combobox is selected*/
        private void countryBox_DropDownClosed(object sender, EventArgs e)
        {
            bindState();//state is binded according to the selected country index

        }


        /*this function will be triggered when the update button is clicked*/
        private void updateButton_Click(object sender, EventArgs e)
        {
            //the values from the updated data fields are inserted back into the datagrid
            user.Rows[rowIndex]["Name"] = nameBox.Text;
            user.Rows[rowIndex]["PhoneNumber"] = numberBox.Text;
            user.Rows[rowIndex]["Country"] = countryBox.Text;
            user.Rows[rowIndex]["State"] = stateBox.Text;

            //string radioValue = getRadioValue();
            //MessageBox.Show(radioValue);

            user.Rows[rowIndex]["Gender"] = getRadioValue();//function is called to set the values at given rowindex
            state.Clear();//clearing the content of the 
            updateButton.Enabled = false;//disabling the update button again

        }
    }
}