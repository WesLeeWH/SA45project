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
    public partial class ManageAuthorList : Form
    {
        bool IsAddNew = false;
        Author author;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManageAuthorList()
        {
            InitializeComponent();
            author = new Author();
            IsAddNew = true;
        }
        public ManageAuthorList(int primarykey)
        {
            InitializeComponent();
            author = context.Authors.Where(x=>x.AuthorID==primarykey).ToList().First();
            textBox8.Text = author.AuthorName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string author_name = textBox8.Text;
            if (author_name !="")
            {
                author.AuthorName = author_name;
                author.CountryCode = Int32.Parse( comboBox1.SelectedValue.ToString());
                if (IsAddNew)
                {
                    context.Authors.Add(author);
                }
                
                context.SaveChanges();
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill the name.");
            }
        }

        private void ManageAuthorList_Load(object sender, EventArgs e)
        {
            ///////Countries
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("name");
            dt3.Columns.Add("value");
            DataRow dr3 = dt3.NewRow();
           var namelist = context.Countries.Select(x => x.CountryName).ToList();
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
