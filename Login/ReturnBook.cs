using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Transactions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ReturnBook : Form
    {
        IssueTran it;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ReturnBook()
        {
            InitializeComponent();
        }
        public ReturnBook(IssueTran it, string bookname)
        {
            InitializeComponent();
            this.it = context.IssueTrans.Where(x=>x.TransactionID == it.TransactionID).ToList().First();
            BookNameBox.Text = bookname;
        }
        private void ReturnBook_Load(object sender, EventArgs e)
                {
                    try
                    {
                        FromdateTimePicker.Value = (DateTime)it.DateIssue;
                        TodateTimePicker.Value = (DateTime)it.DateDue;
                        ActualdateTimePicker1.Value = DateTime.Now.Date;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            
            //if(false)
            if (TodateTimePicker.Value < ActualdateTimePicker1.Value)
            {
                PaymentTran pt = new PaymentTran();
                if (context.PaymentTrans.Count(x => x.TransactionID == it.TransactionID) == 0)
                {
                    pt.TransactionID = it.TransactionID;
                    pt.Fee = CaculateFee(TodateTimePicker.Value, ActualdateTimePicker1.Value);
                    pt.IsPaid = "False";
                    context.PaymentTrans.Add(pt);
                    context.SaveChanges();
                }
                else
                {
                    pt = context.PaymentTrans.Where(x => x.TransactionID == it.TransactionID).ToList().First();
                }
                DialogResult result = MessageBox.Show("Overdue! You must pay the Fee first. \n the Fee is "+pt.Fee, " Warning", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    pt.IsPaid = "True";
                    context.SaveChanges();

                    it.DateActualReturn = ActualdateTimePicker1.Value.Date;
                    it.RentailStatus = "IN";
                    it.IsLate = "True";

                    Book book = context.Books.Where(x => x.BookCode == it.BookCode).ToList().First();
                    book.NumberAvaliable += 1;
                    book.NumberRented -= 1;
                    context.SaveChanges();
                    MessageBox.Show("Success!");
                    this.Close();
                }
            }
            else
            {
                it.DateActualReturn = ActualdateTimePicker1.Value.Date;
                it.RentailStatus = "IN";
                it.IsLate = "False";
            
                Book book = context.Books.Where(x => x.BookCode == it.BookCode).ToList().First();
                book.NumberAvaliable += 1;
                book.NumberRented -= 1;
                context.SaveChanges();
                MessageBox.Show("Success!");
                this.Close();
            }
        }
        private float CaculateFee(DateTime t1,DateTime t2)
        {
            System.TimeSpan ts = t2 - t1;
            int days = ts.Days;
            float Fee = (float)(days*0.5);
            return Fee;
        }
       
    }
}
