using Library_Management_System.Entities;
using Library_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class Borrowers : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Borrowers()
        {
            InitializeComponent();
        }

        private void btnbackbor_Click(object sender, EventArgs e)
        {
            MainForm objmain = new MainForm();
            this.Hide();
            objmain.ShowDialog();
        }
        private void ClearMethod()
        {
            txtbid.Text = "";          
            txtcontact.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtmname.Text = "";
            
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction;

            if (!string.IsNullOrEmpty(txtbid.Text))
            {
                BORROW bor = new BORROW();
                bor.BorrowerId = Convert.ToInt16(txtbid.Text);
                string sqlQuery = "DELETE FROM  BorrowersTable WHERE txtbid=@txtbid";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@BorrowerId", bor.BorrowerId);
                con.Open();
                transaction = con.BeginTransaction();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {

                    MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                    transaction.Commit();
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                    transaction.Rollback();
                }
                con.Close();
                LoadGridView();
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Please select Borrower Id!", "Warning", MessageBoxButtons.OK);
            }
        }
        private void LoadGridView()
        {
            Show();
        }

            private void btnclear_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Borrowers_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        

    

        private void btnclose_Click(object sender, EventArgs e)
        {
            MainForm objmain = new MainForm();
            this.Hide();
            objmain.ShowDialog();
        }
    }
}
