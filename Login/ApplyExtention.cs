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
    public partial class ApplyExtention : Form
    {
        SA45Team03BEntities context = new SA45Team03BEntities();
        IssueTran it;
        string bookname;
        public ApplyExtention()
        {
            InitializeComponent();
        }
        public ApplyExtention(IssueTran it ,string bookname)
        {
            InitializeComponent();
            this.it = it;
            this.bookname = bookname;
        }
        private void ApplyExtention_Load(object sender, EventArgs e)
        {
            TrantextBox.Text = it.TransactionID.ToString();
            NametextBox.Text = bookname;
            IssuetextBox.Text = it.DateIssue.Value.Date.ToShortDateString();
            DueDatetextBox.Text = it.DateDue.Value.Date.ToShortDateString();
        }
        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            string input = ExtenttextBox.Text;
            int extent_days = 0;
            if (input=="")
            {
                MessageBox.Show("Input the day you want to extent!");
            }
            else
            {
                if (Int32.TryParse(input,out extent_days))
                {
                    ExtendApplication ea = new ExtendApplication();
                    ea.TransactionID = it.TransactionID;
                    ea.ExtendDays = extent_days;
                    ea.IsApproved = "False";
                    ea.Remarks = RemarktextBox.Text;

                    context.ExtendApplications.Add(ea);
                    context.SaveChanges();

                    MessageBox.Show("Submit Success!");
                    this.Close();
                }
            }
        }
    }
}
