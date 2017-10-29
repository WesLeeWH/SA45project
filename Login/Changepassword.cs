using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Login
{
    public partial class Changepassword : Form
    {
        SA45Team03BEntities context = new SA45Team03BEntities();
        User user;
        public Changepassword()
        {
            InitializeComponent();
        }
        public Changepassword(User user)
        {
            InitializeComponent();
            this.user = context.Users.Where(x => x.UserName == user.UserName).ToList().First() ;
            Username_textBox.Text = user.UserName;
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string oldpassword = OldPassword_textBox.Text;
            string newpassword = NewPassword_textbox.Text;
            if (oldpassword == user.Password)
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (newpassword.Length<20)
                    {
                        user.Password = newpassword;
                        context.SaveChanges();
                        ts.Complete();
                        MessageBox.Show("Change Success!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("New Password's length must less than 20");
                    }
                }
            }
            else
            {
                MessageBox.Show("Old Password not correct!");
            }
        }
    }
}
