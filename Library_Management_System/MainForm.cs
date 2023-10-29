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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnborrowers_Click(object sender, EventArgs e)
        {
            Borrowers objbro = new Borrowers();
            this.Hide();
            objbro.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login objlog = new Login();
            this.Hide();
            objlog.ShowDialog();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            BookForm objbook = new BookForm();
            this.Hide();
            objbook.ShowDialog();
        }
    }
}
