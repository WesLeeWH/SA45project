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
    public partial class BorrowBook : Form
    {
        SA45Team03BEntities context = new SA45Team03BEntities();
        Customer customer;
        public BorrowBook()
        {
            InitializeComponent();
        }
        public BorrowBook(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }
        private void BorrowBook_Load(object sender, EventArgs e)
        {
            FromdateTimePicker.Value = DateTime.Now;
            TodateTimePicker.Value = FromdateTimePicker.Value.AddDays(3);
            LoadGridView();
            //SetComBox();
        }
        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    int bookcode = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Book book = context.Books.Where(x=>x.BookCode==bookcode).ToList().First();
                    book.NumberAvaliable -= 1;
                    book.NumberRented += 1;

                    IssueTran it = new IssueTran();
                    it.CustomerID = customer.CustomerID;
                    it.BookCode = bookcode;
                    it.DateIssue = FromdateTimePicker.Value.Date;
                    it.DateDue = TodateTimePicker.Value.Date;
                    it.RentailStatus = "OUT";

                    context.IssueTrans.Add(it);
                    context.SaveChanges();
                    MessageBox.Show("Borrw Success!");
                    ts.Complete();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void GetAvaliableDate(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int bookcode = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int? num_avaliable = context.Books.Where(x => x.BookCode == bookcode).Select(x => x.NumberAvaliable).ToList().First();
                if (num_avaliable > 0)
                {
                    FromdateTimePicker.MinDate = DateTime.Now;
                    FromdateTimePicker.Value = DateTime.Now;
                    TodateTimePicker.MinDate = DateTime.Now;
                    TodateTimePicker.Value = FromdateTimePicker.Value.AddDays(1);
                }
                else
                {
                    DateTime date = (DateTime)context.IssueTrans.Where(x => x.BookCode == bookcode).OrderBy
                        (x => x.DateDue).Select(x => x.DateDue).ToList().First();
                    FromdateTimePicker.MinDate = date;
                    FromdateTimePicker.Value = date.AddDays(1);
                    TodateTimePicker.MinDate = date;
                    TodateTimePicker.Value = FromdateTimePicker.Value.AddDays(1);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                
        }
       
        private void LoadGridView()
        {
            dataGridView1.DataSource = context.Books.Select(x => new
            {
                BookCode = x.BookCode,
                BookTitle = x.BookTitle,
                Rating = x.Rating,
                Location = x.Location,
                Author = x.Author.AuthorName,
                Publisher = x.Publisher.PublisherName,
                Country = x.Country.CountryName
            }).ToList();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string search = SearchBox.Text;
            var qrybooktitle = from x in context.Books.
                         Where(x => x.BookTitle.Contains(search) || x.Country.CountryName.Contains(search) ||
                        x.BookCategory.Contains(search) || x.Author.AuthorName.Contains(search) ||
                        x.Publisher.PublisherName.Contains(search) || x.Rating.Contains(search))
                               select new
                               {
                                   x.BookCode,
                                   x.BookTitle,
                                   x.BookCategory,
                                   x.Rating,
                                   x.Author.AuthorName,
                                   x.Country.CountryName,
                                   x.Publisher.PublisherName,
                                   x.Location,
                                   x.NumberAvaliable
                               };
            dataGridView1.DataSource = qrybooktitle.ToList();
            //int i = 0;
            //string rating = RatingcomboBox.SelectedValue.ToString();
            //string author = AuthorBox.SelectedValue.ToString();
            //string publisher = PublishercomboBox.SelectedValue.ToString();
            //string country = CountrycomboBox.SelectedValue.ToString();
            //string BookName = SearchBox.Text;
            //var qry = from x in context.Books select x;
            //if (rating != "All")
            //{
            //     qry = from x in qry
            //              where x.Rating == rating
            //              select x;
            //}
            //if (author !="All")
            //{
            //    i = Int32.Parse(author);
            //    qry = from x in qry
            //          where  x.AuthorID == i
            //          select x;
            //}
            //if (publisher !="All")
            //{
            //    i = Int32.Parse(publisher);
            //    qry = from x in qry
            //          where x.PublisherID == i
            //          select x;
            //}
            //if (country !="All")
            //{
            //    i = Int32.Parse(country);
            //    qry = from x in qry
            //          where x.CountryCode == i
            //          select x;
            //}
            //if (BookName !="")
            //{
            //    var ss = from y in context.Books
            //             where y.BookTitle.Contains(BookName)
            //             select y.BookCode;
            //    qry = from x in qry
            //          where ss.Contains(x.BookCode)
            //          select x;
            //}
            //dataGridView1.DataSource = qry.Select(x => new
            //{
            //    BookCode = x.BookCode,
            //    BookTitle = x.BookTitle,
            //    Rating = x.Rating,
            //    Location = x.Location,
            //    Author = context.Authors.Where
            //        (y => y.AuthorID == x.AuthorID).Select
            //        (y => y.AuthorName).ToList().FirstOrDefault().ToString(),
            //    Publisher = context.Publishers.Where
            //        (z => z.PublisherID == x.PublisherID).Select
            //        (z => z.PublisherName).ToList().FirstOrDefault().ToString(),
            //    Country = context.Countries.Where
            //        (k => k.CountryCode == x.CountryCode).Select
            //        (k => k.CountryName).ToList().FirstOrDefault().ToString()
            //}).ToList();
        }
    }
}
