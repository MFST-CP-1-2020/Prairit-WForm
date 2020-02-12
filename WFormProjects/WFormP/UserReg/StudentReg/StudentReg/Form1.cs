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
        DataTable tab = new DataTable();

        DataTable state = new DataTable();

        DataTable country = new DataTable();

        int rowIndex, columnIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindGrid();
            clearEntries();

            updateButton.Enabled = true;
        }

        void bindGrid()
        {

            DataRow row = tab.NewRow();

            row["Name"] = nameBox.Text;
            row["PhoneNumber"] = numberBox.Text;
            row["Country"] = countryBox.Text;
            row["State"] = stateBox.Text;
            
            row["Gender"] = getRadioValue();

            tab.Rows.Add(row);

            dataGridView1.DataSource = tab;

            addLoadButton();

            addDeleteButton();
            
        }

        void addLoadButton()
        {            
            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.Name = "Load column";
            ButtonColumn.Text = "Load";
            ButtonColumn.UseColumnTextForButtonValue = true;//display name of button
            int columnIndex = 0;
            if (dataGridView1.Columns["Load column"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, ButtonColumn);
            }
        }

        void addDeleteButton()
        {
            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.Name = "Delete column";
            ButtonColumn.Text = "Delete";
            ButtonColumn.UseColumnTextForButtonValue = true;//display name of button
            int columnIndex = 0;
            if (dataGridView1.Columns["Delete column"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, ButtonColumn);
            }
        }

        void clearEntries()
        {
            nameBox.Text = "";
            numberBox.Text = "";
            countryBox.Text = "";
            stateBox.Text = "";
            maleButton.Checked = true;
        }

        string getRadioValue()
        {
            string value;
            bool isChecked = maleButton.Checked;
            if (isChecked)
                value = maleButton.Text;
            else
                value = femaleButton.Text;
            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindControls();
            clearEntries();
        }
        void bindControls()
        {
            bindComboBox();
            createGrid();
        }

        void bindComboBox()
        {
            bindState();
            bindCountry();
        }

        void createGrid()
        {
            tab.Columns.Add("Name", typeof(string));
            tab.Columns.Add("Gender", typeof(string));
            tab.Columns.Add("PhoneNumber", typeof(int));
            tab.Columns.Add("Country", typeof(string));
            tab.Columns.Add("State", typeof(string));
        }

        void bindState()
        {
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

            stateBox.DisplayMember = "Name";
            stateBox.ValueMember = "id";
            stateBox.DataSource = state;


        }

        void getState()
        {

            state.Columns.Add("id", typeof(int));
            state.Columns.Add("Name", typeof(string));

            state.Rows.Add(1, "Uttar Pradesh");
            state.Rows.Add(2, "Haryana");
            state.Rows.Add(3, "Punjab");
            state.Rows.Add(4, "Karnataka");

        }

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

            countryBox.DisplayMember = "Name";
            countryBox.ValueMember = "id";
            countryBox.DataSource = country;
            
        }

        void getCountry()
        {
            country.Columns.Add("id", typeof(int));
            country.Columns.Add("Name", typeof(string));

            country.Rows.Add(1, "India");
            country.Rows.Add(2, "Bhutan");
            country.Rows.Add(3, "Nepal");
            country.Rows.Add(4, "Myanmar");

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            rowIndex = e.RowIndex;
            columnIndex = e.ColumnIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            if (columnIndex == 1)
            {
                nameBox.Text = row.Cells["Name"].Value.ToString();
                numberBox.Text = row.Cells["PhoneNumber"].Value.ToString();
                stateBox.Text = row.Cells["State"].Value.ToString();
                countryBox.Text = row.Cells["Country"].Value.ToString();

                if(row.Cells["Gender"].Value.ToString()=="Male")
                {
                    maleButton.Checked = true;
                }
                else
                {
                    femaleButton.Checked = true;
                }
            }

            else if(columnIndex == 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            tab.Rows[rowIndex]["Name"] = nameBox.Text;
            tab.Rows[rowIndex]["PhoneNumber"] = numberBox.Text;
            tab.Rows[rowIndex]["Country"] = countryBox.Text;
            tab.Rows[rowIndex]["State"] = stateBox.Text;

            //string radioValue = getRadioValue();
            //MessageBox.Show(radioValue);

            tab.Rows[rowIndex]["Gender"] = getRadioValue();

        }
    }
}