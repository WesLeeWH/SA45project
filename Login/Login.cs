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
    public partial class Login : Form
    {
        SA45Team03BEntities context = new SA45Team03BEntities();
        public Login()
        {
            InitializeComponent();
            Message.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Username_textBox.Text;
            string password = Password_textBox.Text;
            try
            {
                if (IsExist(username))
                {
                    if (PasswordIsCorrect(username,password))
                    {
                        OpenHomePage(username);
                    }
                    else
                    {
                        Message.Text = "UserName or Password not correct!";
                    }
                }
                else
                {
                    Message.Text="UserName not exist!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool IsExist(string username)
        {
            try
            {
                var qry = context.Users.Count(x => x.UserName == username);
                if (qry == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private bool PasswordIsCorrect(string username,string password)
        {
            try
            {
                var qry = context.Users.Where(x=>x.UserName == username).Select(x=>x.Password).ToList().First();
                if (qry.ToString() == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private void OpenHomePage(string username)
        {
            try
            {
                User u = context.Users.Where(x => x.UserName == username).ToList().First();
                if (u.UserType == "Customer")
                {
                    new CusHome(u).Show();
                }
                if (u.UserType == "Employee")
                {
                    new StaffHome(u).Show();
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void EnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginBtn_Click(sender, e);
            }
        }
        private void Username_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginBtn_Click(sender, e);
            }
        }
        private void Password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginBtn_Click(sender, e);
            }
        }
    }
}
