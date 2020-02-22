using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace XMLWriter
{
    public partial class Form1 : Form
    {

        List<User> userList = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        void readData()
        {
            userList.Clear();
            XmlDataDocument xmldoc = new XmlDataDocument();

            FileStream fs = new FileStream("D:/Projects/WFormCP/WFormProjects/WFormP/UserReg/XMLWriter/XMLWriter/bin/Debug/userFile.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            XmlNodeList xmlnode = xmldoc.GetElementsByTagName("User");

            //User newUser = new User();

            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                /*xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(3).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(4).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(5).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(5).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(6).InnerText.Trim();
                MessageBox.Show(str);*/
                User newUser = new User();
                newUser.firstName = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                newUser.lastName = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                newUser.Gender = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                newUser.EmailID = xmlnode[i].ChildNodes.Item(3).InnerText.Trim();
                newUser.PhoneNumber = xmlnode[i].ChildNodes.Item(4).InnerText.Trim();
                newUser.State = xmlnode[i].ChildNodes.Item(5).InnerText.Trim();
                newUser.Country = xmlnode[i].ChildNodes.Item(6).InnerText.Trim();
                userList.Add(newUser);
            }
        }

        void bindGrid()
        {
            var source = new BindingSource();
            source.DataSource = userList;
            dataGridView1.DataSource = source;
        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            readData();
            bindGrid();
        }
        void clearEntries()
        {
            fnameBox.Clear();
            numberBox.Clear();
            emailBox.Clear();
            lnameBox.Clear();
            countryBox.ResetText();
            stateBox.ResetText();
            genderBox.Clear();
        }

        void saveData()
        {
            User newUser = new User();

            newUser.firstName = fnameBox.Text;
            newUser.lastName = lnameBox.Text;
            newUser.Gender = genderBox.Text;
            newUser.PhoneNumber =numberBox.Text;
            newUser.EmailID = emailBox.Text;
            newUser.State = stateBox.Text;
            newUser.Country = countryBox.Text;

            userList.Add(newUser);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveData();
            createFile();
            clearEntries();
            //bindGrid();
        }

        void createFile()
        {
            using (XmlWriter writer = XmlWriter.Create("userFile.xml"))
            {
                writer.WriteStartElement("Users");
                foreach (var element in userList)
                {
                    //MessageBox.Show(element.firstName + element.lastName);
                    writer.WriteStartElement("User");
                    writer.WriteElementString("firstName", element.firstName);
                    writer.WriteElementString("lastName", element.lastName);
                    writer.WriteElementString("gender", element.Gender);
                    writer.WriteElementString("emailID", element.EmailID);
                    writer.WriteElementString("phoneNumber", element.PhoneNumber.ToString());
                    writer.WriteElementString("state", element.State);
                    writer.WriteElementString("country", element.Country);
                    writer.WriteEndElement();
                    //MessageBox.Show("file created");
                }
                writer.WriteEndElement();
                writer.Flush();
                /*XmlDataDocument xmldoc = new XmlDataDocument();
                FileStream fs = new FileStream("D:/Projects/WFormCP/WFormProjects/WFormP/UserReg/XMLReader/XMLReader/userFile.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                XmlNodeList xmlnode = xmldoc.GetElementsByTagName("User");
                for (int i = 0; i <= xmlnode.Count - 1; i++)
                {
                    xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                    string str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(3).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(4).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(5).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(5).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(6).InnerText.Trim();
                    MessageBox.Show(str);
                }*/
            }
        }
    }

    class User
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string Gender { set; get; }
        public string EmailID { set; get; }
        public string PhoneNumber { set; get; }
        public string State { set; get; }
        public string Country { set; get; }
    }
}
