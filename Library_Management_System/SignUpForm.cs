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

namespace Library_Management_System
{
    
    public partial class SignUpForm : Form
    {
        Employee objEmployee = new Employee();
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        string imgName;
        string filePath = "";
        string folderPath = @"C:\Users\DELL-01\Desktop\ADOOOOOOOOOOOOO\1271832_Library_Management_System\Library_Management_SystemSln\Library_Management_System\Images\";
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objEmployee.FullName = txtFullName.Text;               
                objEmployee.EmpEmail = txtEmail.Text;
                objEmployee.EmpAddress = txtAddress.Text;
                objEmployee.EmpPassword = txtPassword.Text;
                objEmployee.EmpUserName = txtUserName.Text;               
                objEmployee.ImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                SqlConnection con = new SqlConnection(conStr);
                string SqlQuery = "Insert into Employee values(@FullName,@EmpUserName,@EmpAddress,@EmpEmail,@EmpPassword,@ImagePath)";
                SqlCommand cmd = new SqlCommand(SqlQuery, con);
                cmd.Parameters.AddWithValue("@FullName", objEmployee.FullName);               
                cmd.Parameters.AddWithValue("@EmpEmail", objEmployee.EmpEmail);
                cmd.Parameters.AddWithValue("@EmpAddress", objEmployee.EmpAddress);
                cmd.Parameters.AddWithValue("@EmpPassword", objEmployee.EmpPassword);
                cmd.Parameters.AddWithValue("@EmpUserName", objEmployee.EmpUserName);
                cmd.Parameters.AddWithValue("@ImagePath", objEmployee.ImagePath);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();
                if (rowCount > 0)
                {
                    MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login objLogin = new Login();
                    this.Hide();
                    objLogin.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbEmployee.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login objlog = new Login();
            this.Hide();
            objlog.ShowDialog();
        }
    }
}
