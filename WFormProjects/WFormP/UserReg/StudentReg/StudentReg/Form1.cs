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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = tab.NewRow();

            row["Name"] = textBox1.Text;
            row["PhoneNumber"] = textBox2.Text;
            row["Country"] = comboBox1.Text;
            row["State"] = comboBox2.Text;

            string value;
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;

            row["Gender"] = value;


            tab.Rows.Add(row);

            dataGridView1.DataSource = tab;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tab.Columns.Add("Name",typeof(string));
            tab.Columns.Add("Gender",typeof(string));
            tab.Columns.Add("PhoneNumber",typeof(int));
            tab.Columns.Add("Country",typeof(string));
            tab.Columns.Add("State",typeof(string));

            state.Columns.Add("id",typeof(int));
            state.Columns.Add("Name",typeof(string));

            country.Columns.Add("id", typeof(int));
            country.Columns.Add("Name", typeof(string));
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
            
            country.Rows.Add(1, "India");
            country.Rows.Add(2,"Bhutan");
            country.Rows.Add(3, "Nepal");
            country.Rows.Add(4, "Myanmar");
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
            
            state.Rows.Add(1, "Uttar Pradesh");
            state.Rows.Add(2, "Haryana");
            state.Rows.Add(3, "Punjab");
            state.Rows.Add(4, "Karnataka");

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = country;

            
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = state;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
