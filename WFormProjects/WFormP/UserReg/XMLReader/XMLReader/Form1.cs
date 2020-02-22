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

namespace XMLReader
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

        private void loadButton_Click(object sender, EventArgs e)
        {
            //readData();
            //bindGrid();
            readLINQ();
        }
        void readData()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();

            FileStream fs = new FileStream("D:/Projects/WFormCP/WFormProjects/WFormP/UserReg/XMLReader/XMLReader/userFile.xml", FileMode.Open, FileAccess.Read);
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
                newUser.PhoneNumber = long.Parse(xmlnode[i].ChildNodes.Item(4).InnerText.Trim());
                newUser.State = xmlnode[i].ChildNodes.Item(5).InnerText.Trim();
                newUser.Country = xmlnode[i].ChildNodes.Item(6).InnerText.Trim();
                userList.Add(newUser);
            }
        }

        void bindGrid()
        {
            dataGridView1.DataSource = userList;
        }

        void readLINQ()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:/Projects/WFormCP/WFormProjects/WFormP/UserReg/XMLReader/XMLReader/userFile.xml");
            dataGridView1.DataSource = ds;
        }
    }


    class User
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string Gender { set; get; }
        public string EmailID { set; get; }
        public long PhoneNumber { set; get; }
        public string State { set; get; }
        public string Country { set; get; }
    }
}
