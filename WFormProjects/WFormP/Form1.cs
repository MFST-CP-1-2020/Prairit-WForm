using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormP
{
    public partial class Form1 : Form
    {
        DataTable info = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow newRow = info.NewRow();

            newRow["FirstName"] = "sjsds";

            info.Rows.Add(newRow);

            dataGridView1.DataSource = info;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            info.Columns.Add("FirstName",typeof(string));



        }
    }
}
