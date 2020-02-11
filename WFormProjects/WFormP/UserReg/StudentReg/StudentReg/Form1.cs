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
