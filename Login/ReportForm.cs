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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            string[] sortBook = new string[] { "Category", "Rating", "AuthorName" };
            DataTable dt0 = new DataTable();
            dt0.Columns.Add("name");
            dt0.Columns.Add("value");
            foreach (string s in sortBook)
            {
                DataRow drr0 = dt0.NewRow();
                drr0[0] = s;
                drr0[1] = s;
                dt0.Rows.Add(drr0);
            }
            comboBox1.DataSource = dt0;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";

            string[] sortChart = new string[] { "NumberRented", "RatingChart" };
            DataTable dtt = new DataTable();
            dtt.Columns.Add("name");
            dtt.Columns.Add("value");
            foreach (string s in sortChart)
            {
                DataRow drr1 = dtt.NewRow();
                drr1[0] = s;
                drr1[1] = s;
                dtt.Rows.Add(drr1);
            }
            comboBox2.DataSource = dtt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedValue.ToString();
            ReportContainer pc = new ReportContainer(str);
            pc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = comboBox2.SelectedValue.ToString();
            ReportContainer pc = new ReportContainer(str);
            pc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportContainer pc = new ReportContainer();
            pc.ShowDialog();
        }
    }
}
