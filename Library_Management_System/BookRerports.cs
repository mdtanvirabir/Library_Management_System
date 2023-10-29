using Library_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BookRerports : Form
    {
        List<BookViewModel> lst;
        public BookRerports(List<BookViewModel> list)
        {
            InitializeComponent();
            lst = list;
        }

        public BookRerports()
        {
            InitializeComponent();
        }


        private void BookRerports_Load(object sender, EventArgs e)
        {
            CryBookReports objRpt = new CryBookReports();
            objRpt.SetDataSource(lst);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
