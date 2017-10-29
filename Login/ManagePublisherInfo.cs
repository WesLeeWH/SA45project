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
    public partial class ManagePublisherInfo : Form
    {
        bool IsAddNew = false;
        Publisher pl;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManagePublisherInfo()
        {
            InitializeComponent();
            pl = new Publisher();
            IsAddNew = true;
        }
        public ManagePublisherInfo(int primarykey)
        {
            InitializeComponent();
            pl = context.Publishers.Where(x=>x.PublisherID == primarykey).ToList().First();
            textBox8.Text = pl.PublisherName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pl.PublisherName = textBox8.Text;
            pl.CountryCode = Int32.Parse(comboBox1.SelectedValue.ToString());

            if (IsAddNew)
            {
                context.Publishers.Add(pl);
            }
            context.SaveChanges();
            MessageBox.Show("Success!");
            this.Close();
        }

        private void ManagePublisherInfo_Load(object sender, EventArgs e)
        {
            ///////Countries
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("name");
            dt3.Columns.Add("value");

          var  namelist = context.Countries.Select(x => x.CountryName).ToList();
          var valuelist = context.Countries.Select(x => x.CountryCode).ToList();

            for (int i = 0; i < namelist.Count(); i++)
            {
                DataRow dr = dt3.NewRow();
                dr[0] = namelist[i];
                dr[1] = valuelist[i];
                dt3.Rows.Add(dr);
            }
            comboBox1.DataSource = dt3;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
        }
    }
}
