using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        List<User> userList= new List<User>();

        DataTable state = new DataTable();

        DataTable country = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addStateColumns();
            bindCountry();
        }

        void bindState()
        {
            state.Clear();
            getState();

            stateBox.DisplayMember = "Name";
            stateBox.ValueMember = "id";
            stateBox.DataSource =state;

        }

        void getCountry()
        {
            country.Columns.Add("id");
            country.Columns.Add("Name");

            country.Rows.Add(1, "India");
            country.Rows.Add(2, "Bhutan");
            country.Rows.Add(3, "Nepal");
            country.Rows.Add(4, "Myanmar");
        }


        void bindCountry()
        {
            getCountry();

            countryBox.DisplayMember = "Name";
            countryBox.ValueMember = "id";
            countryBox.DataSource = country;
        }

        void getState()
        {
            //addColumnsToState();
            int index = countryBox.SelectedIndex;//reading the selected index
            switch (index)//switching on the value of index
            {
                case 0:
                    state.Rows.Add(1, "Uttar Pradesh");//if the selected option is india
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
        void addStateColumns()
        {

            state.Columns.Add("id");
            state.Columns.Add("Name");
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            clearEntries();
            if (checkConstrains())
            {
                readInput();
                bindGrid();
            }
            else { MessageBox.Show("Invalid first name"); }
        }

        bool checkConstrains()
        {
            foreach(var name in userList)
            {
                if (fnameBox.Text == name.firstName)
                    return false;
            }
            return true;
        }
        void clearEntries()
        {
            fnameBox.Clear();
            lnameBox.Clear();
            emailBox.Clear();
            countryBox.ResetText();
            stateBox.ResetText();
            numberBox.Clear();
            maleButton.Checked = true;
        }

        void readInput()
        {
            User newUser = new User();
            newUser.firstName = fnameBox.Text;
            newUser.lastName = lnameBox.Text;
            newUser.EmailID = emailBox.Text;
            newUser.Country = countryBox.Text;
            newUser.State = stateBox.Text;
            MessageBox.Show(numberBox.Text);
            newUser.phoneNumber = long.Parse(numberBox.Text);
            newUser.Gender = getRadioValue();
            userList.Add(newUser);
        }

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

        void bindGrid()
        {
            var source = new BindingSource();
            source.DataSource = userList;
            dataGridView1.DataSource = source;
        }

        private void countryBox_DropDownClosed(object sender, EventArgs e)
        {
            bindState();
        }
    }


    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Gender { get; set; }
        public string EmailID { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public long phoneNumber { get; set; }

    }
}
