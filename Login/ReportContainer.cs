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
    public partial class ReportContainer : Form
    {
        string select="";
        public ReportContainer()
        {
            InitializeComponent();
        }
        public ReportContainer(string str)
        {
            InitializeComponent();
            select = str;
        }

        private void ReportContainer_Load(object sender, EventArgs e)
        {
            BookViewDataSet bs = new BookViewDataSet();
            BookViewDataSetTableAdapters.BookViewTableAdapter ta 
                = new BookViewDataSetTableAdapters.BookViewTableAdapter();
            ta.Fill(bs.BookView);

            if (select == "Category")
            {
                BookCatReport brpt = new BookCatReport();
                brpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = brpt;
            }
            else if (select == "Rating")
            {
                BookRatingReport raterpt = new BookRatingReport();
                raterpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = raterpt;
            }
            else if (select == "AuthorName")
            {
                BookAuthorReport autrpt = new BookAuthorReport();
                autrpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = autrpt;
            }
            else if (select == "NumberRented")
            {
                NumberRentedChart nrpt = new NumberRentedChart();
                nrpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = nrpt;
            }
            else if (select == "RatingChart")
            {
                RatingChartReport rcrpt = new RatingChartReport();
                rcrpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = rcrpt;
            }
            else if (select == "")
            {
                CrossTab rpt = new CrossTab();
                rpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = rpt;
            }
        }
    }
}
