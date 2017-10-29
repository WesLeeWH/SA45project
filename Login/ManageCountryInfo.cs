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
    public partial class ManageCountryInfo : Form
    {
        bool IsAddNew = false;
        Country ctry;
        SA45Team03BEntities context = new SA45Team03BEntities();
        public ManageCountryInfo()
        {
            InitializeComponent();
            ctry = new Country();
            IsAddNew = true;
        }
        public ManageCountryInfo(int primarykey)
        {
            InitializeComponent();
            ctry = context.Countries.Where(x=>x.CountryCode == primarykey).ToList().First();
            textBox8.Text = ctry.CountryName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctry.CountryName = textBox8.Text;
            if (IsAddNew)
            {
                context.Countries.Add(ctry);
            }
            context.SaveChanges();
            MessageBox.Show("Success!");
            this.Close();
        }
    }
}
