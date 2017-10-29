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
    public partial class ManagePaymentTran : Form
    {
        bool IsAddNew = false;
        PaymentTran pt;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManagePaymentTran()
        {
            InitializeComponent();
            pt = new PaymentTran();
            IsAddNew = true;
        }
        public ManagePaymentTran(int primarykey)
        {
            InitializeComponent();
            pt = context.PaymentTrans.Where(x=>x.PaymentID ==primarykey).ToList().First();
            textBox1.Text = pt.TransactionID.ToString();
            textBox2.Text = pt.Fee.ToString();
            if(pt.Remarks != null)
                textBox8.Text = pt.Remarks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pt.TransactionID = Int32.Parse(textBox1.Text);
            pt.Fee = Double.Parse(textBox2.Text);
            pt.IsPaid = comboBox1.SelectedValue.ToString();
            pt.Remarks = textBox8.Text;

            if (IsAddNew)
            {
                context.PaymentTrans.Add(pt);
            }
            context.SaveChanges();
            MessageBox.Show("Success!");
            this.Close();
        }

        private void ManagePaymentTran_Load(object sender, EventArgs e)
        {
            ///////Rating
            string[] rating = new string[] {"True","False" };
            DataTable dt0 = new DataTable();
            dt0.Columns.Add("name");
            dt0.Columns.Add("value");
            foreach (string s in rating)
            {
                DataRow dr = dt0.NewRow();
                dr[0] = s;
                dr[1] = s;
                dt0.Rows.Add(dr);
            }
            comboBox1.DataSource = dt0;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
        }
    }
}
