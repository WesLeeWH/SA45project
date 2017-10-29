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
    public partial class CusHome : Form
    {
        SA45Team03BEntities context = new SA45Team03BEntities();
        Customer customer;
        User user;
        List<IssueTran> IssueTranList;
        public CusHome()
        {
            InitializeComponent();
        }
        public CusHome(User user ) //triggered from login page
        {
            InitializeComponent();
            this.user = user; //assigning attribute
        }
        private void CusHome_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.Date.ToShortDateString(); //display date and time
            //taking the object of the first in table. user info from login info
            customer = context.Customers.Where(x => x.CustomerID == user.UserID).ToList().First(); 
            //customer object contained customer name
            CusNameLabel.Text = customer.CustomerName;
            //calling this method to load the data grid view
            LoadTheDataGridView();
        }
        private void LoadTheDataGridView()
        {
            //assign the list of data into issuetranlist
            IssueTranList = context.IssueTrans.Where(x => x.CustomerID == customer.CustomerID).ToList();

            //thats the name of the gridView...transactiondatagridview. lol
            TransactiondataGridView.DataSource = context.IssueTrans.Where
                (x=>x.CustomerID==customer.CustomerID && x.RentailStatus=="OUT").Select
                (x => new{
                    TrasactionID = x.TransactionID,
                    BookName =x.Book.BookTitle,
                    DateIssue = x.DateIssue,
                    DateDue = x.DateDue
                }).ToList();
            AutoSizeColumn(TransactiondataGridView);
        }

        private void ChangePasswordbtn_Click(object sender, EventArgs e)
        {
            //can use like that de ah!!! no need to use changepassword cp = new changepassword(user)
            //showdialog will follow changepassword. SMART! just shorten only
                        new Changepassword(user).ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
       
        private void AutoSizeColumn(DataGridView dgViewFiles)
         {
             int width = 0;
             //使列自使用宽度
             //对于DataGridView的每一个列都调整
             for (int i = 0; i<dgViewFiles.Columns.Count; i++)
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
            if (dgViewFiles.Rows.Count>0)
            {
                dgViewFiles.Columns[1].Frozen = true;
            }
         }

        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            if (IssueTranList.Count()==0)
            {
                MessageBox.Show("You have no book need to be returned!");
            }
            else
            {
                var curent_row = TransactiondataGridView.CurrentRow; 
                if (curent_row!=null)
                {
                    int issuetran_id = Int32.Parse(TransactiondataGridView.CurrentRow.Cells[0].Value.ToString());
                    string bookname = TransactiondataGridView.CurrentRow.Cells[1].Value.ToString();
                    IssueTran it = context.IssueTrans.Where(x => x.TransactionID == issuetran_id).ToList().First();
                    new ReturnBook(it, bookname).ShowDialog();
                    LoadTheDataGridView();
                }
                else
                {
                    MessageBox.Show("You must select a book first.");
                }
            }
        }

        private void BorrowBookBtn_Click(object sender, EventArgs e)
        {
            new BorrowBook(customer).ShowDialog();
            LoadTheDataGridView();
        }

        private void ExtendLoanBtn_Click(object sender, EventArgs e)
        {
            int issuetran_id = Int32.Parse(TransactiondataGridView.CurrentRow.Cells[0].Value.ToString());
            string bookname = TransactiondataGridView.CurrentRow.Cells[1].Value.ToString();
            IssueTran it = context.IssueTrans.Where(x => x.TransactionID == issuetran_id).ToList().First();
            new ApplyExtention(it,bookname).ShowDialog();
        }

        //omg what is this???
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
    }
}
