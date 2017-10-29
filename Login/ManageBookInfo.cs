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
    public partial class ManageBookInfo : Form
    {
        bool IsAddNew = false;
        Book book;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManageBookInfo()
        {
            InitializeComponent();
            book = new Book();
            IsAddNew = true;
        }
        public ManageBookInfo(int primarykey)
        {
            InitializeComponent();
            book = context.Books.Where(x=>x.BookCode==primarykey).ToList().First();
            textBox1.Text = book.BookTitle;
            textBox2.Text = book.TotalStock.ToString();
            textBox3.Text = book.NumberAvaliable.ToString();
            textBox4.Text = (book.TotalStock - book.NumberAvaliable).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            book.BookTitle=textBox1.Text;
            book.TotalStock= Int32.Parse( textBox2.Text);
            book.NumberAvaliable= Int32.Parse(textBox3.Text) ;
            book.NumberRented = book.TotalStock - book.NumberAvaliable;
            book.BookCategory= CategorycomboBox.SelectedValue.ToString();
            book.AuthorID = Int32.Parse( AuthorBox.SelectedValue.ToString());
            book.PublisherID = Int32.Parse(PublishercomboBox.SelectedValue.ToString());
            book.Location = LocationcomboBox.SelectedValue.ToString();
            book.CountryCode = Int32.Parse(CountrycomboBox.SelectedValue.ToString());
            book.Rating = RatingcomboBox.SelectedValue.ToString();
            if (IsAddNew)
            {
                context.Books.Add(book);
            }
            context.SaveChanges();
            MessageBox.Show("Success!");
            this.Close();
        }

        private void ManageBookInfo_Load(object sender, EventArgs e)
        {
            SetComBox();
        }
        private void SetComBox()
        {
            ///////Rating
            string[] rating = new string[] { "A", "B", "C", "D", "E", "F" };
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
            RatingcomboBox.DataSource = dt0;
            RatingcomboBox.DisplayMember = "name";
            RatingcomboBox.ValueMember = "value";
            ///////Author
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("name");
            dt1.Columns.Add("value");         
            var namelist = context.Authors.Select(x => x.AuthorName).ToList();
            var valuelist = context.Authors.Select(x => x.AuthorID).ToList();
            for (int i = 0; i < namelist.Count(); i++)
            {
                DataRow dr = dt1.NewRow();
                dr[0] = namelist[i];
                dr[1] = valuelist[i];
                dt1.Rows.Add(dr);
            }
            AuthorBox.DataSource = dt1;
            AuthorBox.DisplayMember = "name";
            AuthorBox.ValueMember = "value";
            ///////Publisher
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("name");
            dt2.Columns.Add("value");
           
            namelist = context.Publishers.Select(x => x.PublisherName).ToList();
            valuelist = context.Publishers.Select(x => x.PublisherID).ToList();
          
            for (int i = 0; i < namelist.Count(); i++)
            {
                DataRow dr = dt2.NewRow();
                dr[0] = namelist[i];
                dr[1] = valuelist[i];
                dt2.Rows.Add(dr);
            }
            PublishercomboBox.DataSource = dt2;
            PublishercomboBox.DisplayMember = "name";
            PublishercomboBox.ValueMember = "value";
            ///////Countries
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("name");
            dt3.Columns.Add("value");
          
            namelist = context.Countries.Select(x => x.CountryName).ToList();
            valuelist = context.Countries.Select(x => x.CountryCode).ToList();
           
            for (int i = 0; i < namelist.Count(); i++)
            {
                DataRow dr = dt3.NewRow();
                dr[0] = namelist[i];
                dr[1] = valuelist[i];
                dt3.Rows.Add(dr);
            }
            CountrycomboBox.DataSource = dt3;
            CountrycomboBox.DisplayMember = "name";
            CountrycomboBox.ValueMember = "value";
            ///////Category
            string[] Category = new string[] { " Novel", "Horror", "Thriller", "Adventure", "History", "Poem", "Romance", "Business" };
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
            CategorycomboBox.DataSource = dt4;
            CategorycomboBox.DisplayMember = "name";
            CategorycomboBox.ValueMember = "value";
            ///////location
            string[] location = new string[] { "Bookcase01","Bookcase02","Bookcase03" };
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
            LocationcomboBox.DataSource = dt5;
            LocationcomboBox.DisplayMember = "name";
            LocationcomboBox.ValueMember = "value";
        }
    }
}
