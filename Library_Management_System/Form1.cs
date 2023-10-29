using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void txtuser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtuser.Text == "Username")
            {
                txtuser.Clear();
            }
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void pcboxfacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/abir.hussain005/");
        }

        private void pcboxyoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC7r5b2QElW44ifS96UEFpcQ");
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            SignUpForm objSignUp = new SignUpForm();
            this.Hide();
            objSignUp.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userName = txtuser.Text;
            string pass = txtpassword.Text;
            SqlConnection con = new SqlConnection(conStr);
            string SqlQuery = "SELECT * FROM Employee WHERE EmpUserName='" + userName + "' and EmpPassword='" + pass + "'";
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@pass", pass);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows == true)
            {
                con.Close();
                MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm objmain = new MainForm();
                this.Hide();
                objmain.ShowDialog();


            }
            
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
