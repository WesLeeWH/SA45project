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
    public partial class StaffHome : Form
    {
        enum ButtonClicked
        {
            BookList,
            CustomerList,
            Extention,
            IssueTran,
            PaymentTran,
            AuthorList,
            PublisherList,
            CountryList
        }
        ButtonClicked clickedBtn;
        User user;
        Employee employee;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public StaffHome()
        {
            InitializeComponent();
        }
        public StaffHome(User u)
        {
            InitializeComponent();
            this.user = u;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int primarykey;
            if (dataGridView.Rows.Count > 0)
            {
                if (Int32.TryParse(dataGridView.CurrentRow.Cells[0].Value.ToString(), out primarykey))
                {
                    switch (clickedBtn)
                    {
                        case ButtonClicked.BookList:
                            {
                                Book item = context.Books.Where(x=>x.BookCode == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.Books.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                        case ButtonClicked.CustomerList:
                            {
                                Customer item = context.Customers.Where(x => x.CustomerID == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.Customers.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                        case ButtonClicked.Extention:
                            {
                                ExtendApplication item = context.ExtendApplications.Where(x => x.ApplicationID == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.ExtendApplications.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                        case ButtonClicked.IssueTran:
                            {
                                IssueTran item = context.IssueTrans.Where(x => x.TransactionID == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.IssueTrans.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                        case ButtonClicked.PaymentTran:
                            {
                                PaymentTran item = context.PaymentTrans.Where(x => x.PaymentID == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.PaymentTrans.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                        case ButtonClicked.AuthorList:
                            {
                                Author item = context.Authors.Where(x => x.AuthorID == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.Authors.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                        case ButtonClicked.PublisherList:
                            {
                                Publisher item = context.Publishers.Where(x => x.PublisherID == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.Publishers.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                        case ButtonClicked.CountryList:
                            {
                                Country item = context.Countries.Where(x => x.CountryCode == primarykey).ToList().First();
                                if (ConfirmDelete())
                                {
                                    context.Countries.Remove(item);
                                    context.SaveChanges();
                                    MessageBox.Show("Delete success!");
                                }
                                break;
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data in the table");
            }
        }

        private bool ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", " Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ChangePasswordbtn_Click(object sender, EventArgs e)
        {
            new Changepassword(user).ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            switch (clickedBtn)
            {
                case ButtonClicked.BookList:
                    {
                        new ManageBookInfo().ShowDialog();
                        break;
                    }
                case ButtonClicked.CustomerList:
                    {
                        new ManageCustomerInfo().ShowDialog();
                        break;
                    }
                case ButtonClicked.Extention:
                    {
                        new ManageExtendeApplication().ShowDialog();
                        break;
                    }
                case ButtonClicked.IssueTran:
                    {
                        new ManageIssueTran().ShowDialog();
                        break;
                    }
                case ButtonClicked.PaymentTran:
                    {
                        new ManagePaymentTran().ShowDialog();
                        break;
                    }
                case ButtonClicked.AuthorList:
                    {
                        new ManageAuthorList().ShowDialog();
                        break;
                    }
                case ButtonClicked.PublisherList:
                    {
                        new ManagePublisherInfo().ShowDialog();
                        break;
                    }
                case ButtonClicked.CountryList:
                    {
                        new ManageCountryInfo().ShowDialog();
                        break;
                    }
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void StaffHome_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.Date.ToShortDateString();
            employee = context.Employees.Where(x => x.Employee1 == user.UserID).ToList().First();
            StaffNameLabel.Text = employee.EmployeeName;
            //default as book list
            clickedBtn = ButtonClicked.BookList;
            dataGridView.DataSource = context.Books.Select
                (x => new {
                    BookCode = x.BookCode,
                    BookTitle = x.BookTitle,
                    BookCategory = x.BookCategory,
                    BookRating = x.Rating,
                    BookLocation = x.Location,
                    Author = x.Author.AuthorName,
                    Publisher = x.Publisher.PublisherName,
                    Country = x.Country.CountryName
                }).ToList();
            AutoSizeColumn(dataGridView);
        }

        private void ViewBookListBtn_Click(object sender, EventArgs e)
        {
            //enum of booklist triggered
            clickedBtn = ButtonClicked.BookList;
            dataGridView.DataSource = context.Books.Select
                (x => new {
                    BookCode = x.BookCode,
                    BookTitle = x.BookTitle,
                    BookCategory = x.BookCategory,
                    BookRating = x.Rating,
                    BookLocation = x.Location,
                    Author =x.Author.AuthorName,
                    Publisher = x.Publisher.PublisherName,
                    Country = x.Country.CountryName,
                    TotalStock = x.TotalStock,
                    NumberAvaliable = x.NumberAvaliable,
                    NumberRented = x.NumberRented
                }).ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = true;
        }

        private void ViewCusListBtn_Click(object sender, EventArgs e)
        {
            clickedBtn = ButtonClicked.CustomerList;
            dataGridView.DataSource = context.Customers.Select(x=>new
            {
                x.CustomerID,
                x.CustomerName,
                x.CustomerCategory,
                x.Age,
                x.Address,
                x.City,
                x.PostalCode,
                x.ContactTitle,
                x.PhoneNumber,
                x.EmailAddress,
                x.Notes
            }
                ).ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = true;
        }

        private void ViewExtentionAppBtn_Click(object sender, EventArgs e)
        {
            clickedBtn = ButtonClicked.Extention;
            dataGridView.DataSource = context.ExtendApplications.Select
                (x=>new{
                    x.ApplicationID,
                    x.TransactionID,
                    x.ExtendDays,
                    x.IsApproved,
                    x.Remarks
                }).ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = false;
        }

        private void ViewIssueTranBtn_Click(object sender, EventArgs e)
        {
            clickedBtn = ButtonClicked.IssueTran;
            dataGridView.DataSource = context.IssueTrans.Select
                (x => new {
                    TransactionID = x.TransactionID,
                    CustomerID = x.CustomerID.Value.ToString(),
                    BookCode = x.BookCode.Value.ToString(),
                    DateIssue = x.DateIssue,
                    DateDue = x.DateDue,
                    RentailStatus = x. RentailStatus,
                    IsLate = x.IsLate,
                    Remarks = x.Remarks
                }).ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = false;
        }

        private void ViewPaymentTranBtn_Click(object sender, EventArgs e)
        {
            clickedBtn = ButtonClicked.PaymentTran;
            dataGridView.DataSource = context.PaymentTrans.Select
                (x => new {
                    PaymentID = x.PaymentID,
                    TransationID = x.TransactionID.Value.ToString(),
                    Fee = x.Fee,
                    IsPaid = x.IsPaid,
                    Remarks = x.Remarks,
                }). ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = false;
        }

        private void ViewAuthorListBtn_Click(object sender, EventArgs e)
        {
            clickedBtn = ButtonClicked.AuthorList;
            dataGridView.DataSource = context.Authors.Select(x=>new {
                AuthorID = x.AuthorID,
                AuthorName = x.AuthorName,
                Country= x.Country.CountryName
            }).ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = true;
        }

        private void ViewPublisherListbtn_Click(object sender, EventArgs e)
        {
            clickedBtn = ButtonClicked.PublisherList;
            dataGridView.DataSource = context.Publishers.Select(x=>new
            {
                x.PublisherID,
                x.PublisherName,
                x.Country.CountryName
            }).ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = true;
        }

        private void ViewCountryListBtn_Click(object sender, EventArgs e)
        {
            clickedBtn = ButtonClicked.CountryList;
            dataGridView.DataSource = context.Countries.Select(x=>new
            {
                x.CountryCode,
                x.CountryName
            }).ToList();
            AutoSizeColumn(dataGridView);
            AddBtn.Enabled = true;
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
            dataGridView.DataSource = qrybooktitle.ToList();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int primarykey;
            if (dataGridView.Rows.Count>0)
            {
                if (Int32.TryParse(dataGridView.CurrentRow.Cells[0].Value.ToString(), out primarykey))
                {
                    switch (clickedBtn)
                    {
                        case ButtonClicked.BookList:
                            {
                                new ManageBookInfo(primarykey).ShowDialog();
                                break;
                            }
                        case ButtonClicked.CustomerList:
                            {
                                new ManageCustomerInfo(primarykey).ShowDialog();
                                break;
                            }
                        case ButtonClicked.Extention:
                            {
                                new ManageExtendeApplication(primarykey).ShowDialog();
                                break;
                            }
                        case ButtonClicked.IssueTran:
                            {
                                new ManageIssueTran(primarykey).ShowDialog();
                                break;
                            }
                        case ButtonClicked.PaymentTran:
                            {
                                new ManagePaymentTran(primarykey).ShowDialog();
                                break;
                            }
                        case ButtonClicked.AuthorList:
                            {
                                new ManageAuthorList(primarykey).ShowDialog();
                                break;
                            }
                        case ButtonClicked.PublisherList:
                            {
                                new ManagePublisherInfo(primarykey).ShowDialog();
                                break;
                            }
                        case ButtonClicked.CountryList:
                            {
                                new ManageCountryInfo(primarykey).ShowDialog();
                                break;
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data in the table");
            }
        }

        private void AutoSizeColumn(DataGridView dgViewFiles)
        {
            int width = 0;
            //使列自使用宽度
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < dgViewFiles.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                dgViewFiles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += dgViewFiles.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，
            //如果是小于原来设定的宽度，将模式改为填充。
            if (width > dgViewFiles.Size.Width)
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1，2
            if (dgViewFiles.Rows.Count > 0)
            {
                dgViewFiles.Columns[0].Frozen = true;
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                Application.Exit();
            }
            base.WndProc(ref m);
        }

        private void GetReportBtn_Click(object sender, EventArgs e)
        {
            new ReportForm().ShowDialog() ;
        }
    }
}
