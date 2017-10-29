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
    public partial class ManageExtendeApplication : Form
    {
        bool IsAddNew = false;
        ExtendApplication ea;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManageExtendeApplication()
        {
            InitializeComponent();
            ea = new ExtendApplication();
        }
        public ManageExtendeApplication(int primarykey)
        {
            InitializeComponent();
            ea = context.ExtendApplications.Where(x=>x.ApplicationID == primarykey).ToList().First();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ea.IsApproved = "True";
            ea.Remarks = textBox8.Text;
            IssueTran it = ea.IssueTran;
            it.DateDue = it.DateDue.Value.AddDays((double)ea.ExtendDays);
            context.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageExtendeApplication_Load(object sender, EventArgs e)
        {
            textBox7.Text = ea.TransactionID.ToString();
            textBox3.Text = ea.IssueTran.Book.BookTitle;
            textBox2.Text = ea.IssueTran.Customer.CustomerName;
            textBox4.Text = ea.IssueTran.DateIssue.Value.ToShortDateString();
            textBox6.Text = ea.IssueTran.DateDue.Value.ToShortDateString();
            textBox5.Text = ea.ExtendDays.ToString();
            textBox1.Text = ea.IsApproved;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
