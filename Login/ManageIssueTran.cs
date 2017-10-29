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
    public partial class ManageIssueTran : Form
    {
        bool IsAddNew = false;
        IssueTran it;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManageIssueTran()
        {
            InitializeComponent();
            it = new IssueTran();
            IsAddNew = true;
        }
        public ManageIssueTran(int primarykey)
        {
            InitializeComponent();
            it = context.IssueTrans.Where(x=>x.TransactionID == primarykey).ToList().First();
            textBox3.Text = it.BookCode.ToString();
            textBox2.Text = it.CustomerID.ToString();
            dateTimePicker1.Value =(DateTime) it.DateIssue;
            dateTimePicker2.Value = (DateTime)it.DateDue;
            dateTimePicker3.Value = (DateTime)it.DateActualReturn;
            textBox8.Text = it.Remarks;
        }
        private void ManageIssueTran_Load(object sender, EventArgs e)
        {
            ///////Category
            string[] Category = new string[] {"OUT","IN"};
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
            comboBox2.DataSource = dt4;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "value";
            ///////location
            string[] location = new string[] { "True","False"};
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
            comboBox1.DataSource = dt5;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            it.CustomerID = Int32.Parse(textBox2.Text);
            it.BookCode = Int32.Parse(textBox3.Text);
            it.DateIssue = dateTimePicker1.Value.Date;
            it.DateDue = dateTimePicker2.Value.Date;
            it.DateActualReturn = dateTimePicker3.Value.Date;
            it.RentailStatus = comboBox2.SelectedValue.ToString();
            it.IsLate = comboBox1.SelectedValue.ToString();
            it.Remarks = textBox8.Text;

            if (IsAddNew)
            {
                context.IssueTrans.Add(it);
            }
            context.SaveChanges();
            MessageBox.Show("Success!");
            this.Close();
        }
    }
}
