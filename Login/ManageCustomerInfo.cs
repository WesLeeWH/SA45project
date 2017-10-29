using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ManageCustomerInfo : Form
    {
        bool IsAddNew = false;
        Customer cust;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManageCustomerInfo()
        {
            InitializeComponent();
            cust = new Customer();
            IsAddNew = true;
        }
        public ManageCustomerInfo(int primarykey)
        {
            InitializeComponent();
            cust = context.Customers.Where(x => x.CustomerID == primarykey).ToList().First();
            textBox1.Text = cust.CustomerName;
            textBox5.Text = cust.Age.ToString();
            textBox6.Text = cust.Address.ToString();
            textBox7.Text = cust.City.ToString();
            textBox8.Text = cust.PostalCode.ToString();
            textBox2.Text = cust.PhoneNumber.ToString();
            textBox3.Text = cust.EmailAddress.ToString();
            if (cust.Notes!=null)
                textBox4.Text = cust.Notes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust.CustomerName = textBox1.Text;
            cust.CustomerCategory = comboBox1.SelectedValue.ToString();
            cust.Age = Int32.Parse(textBox5.Text);
            cust.Address = textBox6.Text;
            cust.City = textBox7.Text;
            cust.PostalCode = textBox8.Text;
            cust.ContactTitle = comboBox6.SelectedValue.ToString();
            cust.PhoneNumber = textBox2.Text;
            cust.EmailAddress = textBox3.Text;
            cust.Notes = textBox4.Text;
            if (IsAddNew)
            {
                context.Customers.Add(cust);
            }
            context.SaveChanges();
            MessageBox.Show("Success!");
            this.Close();
        }

        private void ManageCustomerInfo_Load(object sender, EventArgs e)
        {
            ///////Category
            string[] Category = new string[] { "Childen","Student","Adult","Senior Citizen"};
            DataTable dt4 = new DataTable();
            dt4.Columns.Add("name");
            dt4.Columns.Add("value");
            foreach (string s in Category)
            {
                DataRow dr = dt4.NewRow();
                dr[0] = s;
                dr[1] = s;
                dt4.Rows.Add(dr);
            }
            comboBox1.DataSource = dt4;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
            ///////location
            string[] location = new string[] { "MR","MS" };
            DataTable dt5 = new DataTable();
            dt5.Columns.Add("name");
            dt5.Columns.Add("value");
            foreach (string s in location)
            {
                DataRow dr = dt5.NewRow();
                dr[0] = s;
                dr[1] = s;
                dt5.Rows.Add(dr);
            }
            comboBox6.DataSource = dt5;
            comboBox6.DisplayMember = "name";
            comboBox6.ValueMember = "value";
        }
    }
}
