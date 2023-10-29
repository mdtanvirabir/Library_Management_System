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
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class BookForm : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        bool status;
        int EmployeeId = 8;       
        string imgName;
        string filePath = "";
        string folderPath = @"C:\Users\LAB-1\Desktop\1271832\1271832_Library_Management_System\Library_Management_SystemSln\Library_Management_System\Images\";
        string imagePathFromData;
        public BookForm()
        {
            InitializeComponent();
        }

        private void cmbsearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbbook.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }
        private void ClearMethod()
        {
            txtbookid.Text = "";
            txtbookname.Text = "";
            txtuthorname.Text = "";
            txtpublisher.Text = "";
            dtppublishDate.Text = "";
            txtQuantity.Text = "";
            txtrent.Text = "";
            cmbbor.SelectedValue= 0;
            pbbook.Image = Resources.noimage;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeName();
            LoadBook();            
            pbbook.Image = Resources.noimage;
            LoadGridView();
            LodeBorrowerName();
        }

        private void LoadBook()
        {
            string sqlQuery = "SELECT * FROM Borrowers";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbbor.DisplayMember = "FirstName";
                cmbbor.ValueMember = "BorrowerId";
                cmbbor.DataSource = dt;
            }
            con.Close();
        }

        private void LodeBorrowerName()
        {
            string sqlQuery = "SELECT * FROM Borrowers";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbbor.DisplayMember = "FirstName";
                cmbbor.ValueMember = "BorrowerId";
                cmbbor.DataSource = dt;
            }
            con.Close();
        }

        private void LoadEmployeeName()
        {
            string userName = "";
            string sqlQuery = "SELECT FullName FROM Employee WHERE EmployeeId='" + EmployeeId + "'";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            userName = (cmd.ExecuteScalar()).ToString();
            if (userName == "")
            {
                lblEmployeeName.Text = "Unknown";
            }
            lblEmployeeName.Text = userName;
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bookclass objbook = new bookclass();
            decimal totalpayment = Convert.ToDecimal(txtrent.Text);
            objbook.BookName = (txtbookname.Text);
            objbook.AuthorName=txtuthorname.Text;
            objbook.Publisiher =(txtpublisher.Text);
            objbook.PbulishDate = Convert.ToDateTime(dtppublishDate.Text);
            objbook.Quantity = Convert.ToInt16(txtQuantity.Text);
            objbook.BookRentAmount = totalpayment * objbook.Quantity;
            objbook.ImgPath = folderPath + Path.GetFileName(openFileDialog1.FileName);
            objbook.Available = status;            
            objbook.EmployeeId = EmployeeId;
            objbook.BorrowerId = Convert.ToInt32(cmbbor.SelectedValue);

            string sqlQuery = "Insert INTO Book VALUES (@BookName,@AuthorName,@Publisiher,@PbulishDate,@Quantity,@BookRentAmount,@ImgPath,@Available,@EmployeeId,@BorrowerId)";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            if (filePath == "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", "No Image Found");
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ImagePath", objbook.ImgPath);
                try
                {
                    File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cmd.Parameters.AddWithValue("@BookName", objbook.BookName);
            cmd.Parameters.AddWithValue("@AuthorName", objbook.AuthorName);
            cmd.Parameters.AddWithValue("@Publisiher", objbook.Publisiher);
            cmd.Parameters.AddWithValue("@PbulishDate", objbook.PbulishDate);
            cmd.Parameters.AddWithValue("@Quantity", objbook.Quantity);
            cmd.Parameters.AddWithValue("@BookRentAmount", objbook.BookRentAmount);
            cmd.Parameters.AddWithValue("@ImgPath", objbook.ImgPath);
            cmd.Parameters.AddWithValue("@Available", objbook.Available);
            cmd.Parameters.AddWithValue("@EmployeeId", objbook.EmployeeId);
            cmd.Parameters.AddWithValue("@BorrowerId", objbook.BorrowerId);
            con.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                MessageBox.Show("Borrower Information added successfully!", "Success", MessageBoxButtons.OK);
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Borrower Insertion failed!", "Failure", MessageBoxButtons.OK);
                ClearMethod();
            }
            con.Close();
            LoadGridView();
            ClearMethod();
        }

        private void LoadGridView()
        {

            string sqlQuery = "SELECT b.BookId, b.BookName, b.AuthorName, b.Publisher,b.PbulishDate,b.Quantity,b.BookRentAmount,b.Available,b.EmployeeId,b.BorrowerId, br.FirstName,em.FullName,b.ImgPath   FROM Book b JOIN Borrowers br ON b.BorrowerId=br.BorrowerId JOIN Employee em ON b.EmployeeId=em.EmployeeId";
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            dt.Columns.Add("Picture", Type.GetType("System.Byte[]"));
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    dr["Picture"] = File.ReadAllBytes(dr["ImgPath"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            dgvgreed.RowTemplate.Height = 52;
            dgvgreed.DataSource = dt;
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage = (DataGridViewImageColumn)dgvgreed.Columns[13];
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvgreed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void lblbook_Click(object sender, EventArgs e)
        {

        }

        private void lblauthor_Click(object sender, EventArgs e)
        {

        }

        private void radiomale_CheckedChanged(object sender, EventArgs e)
        {
            status = true;
        }

        private void radiofemale_CheckedChanged(object sender, EventArgs e)
        {
            status = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbookid.Text))
            {
                decimal totalpayment = Convert.ToDecimal(txtrent.Text);
                bookclass objupdate = new bookclass();
                objupdate.Quantity = Convert.ToInt16(txtQuantity.Text);
                objupdate.BookRentAmount = totalpayment * objupdate.Quantity;
                
                objupdate.BookId = Convert.ToInt16(txtbookid.Text);
                objupdate.BookName = (txtbookname.Text);
                objupdate.AuthorName = txtuthorname.Text;
                objupdate.Publisiher = (txtpublisher.Text);
                objupdate.PbulishDate = Convert.ToDateTime(dtppublishDate.Text);
                objupdate.BookRentAmount = totalpayment * objupdate.Quantity;
                objupdate.ImgPath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                objupdate.Available = status;
                objupdate.EmployeeId = EmployeeId;
                objupdate.BorrowerId = Convert.ToInt32(cmbbor.SelectedValue);
                objupdate.ImgPath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                
                string sqlQuery = "UPDATE Book SET BookName =@BookName,AuthorName =@AuthorName,Publisher= @Publisher,PbulishDate =@PbulishDate,Quantity =@Quantity,BookRentAmount =@BookRentAmount,ImgPath =@ImgPath,Available =@Available,EmployeeId =@EmployeeId,BorrowerId =@BorrowerId WHERE BookId = @BookId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                if (filePath == "")
                {
                    cmd.Parameters.AddWithValue("@ImagePath", imagePathFromData);
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ImagePath", objupdate.ImgPath);
                    try
                    {
                        File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                cmd.Parameters.AddWithValue("@BookName", objupdate.BookName);
                cmd.Parameters.AddWithValue("@AuthorName", objupdate.AuthorName);
                cmd.Parameters.AddWithValue("@Publisher", objupdate.Publisiher);
                cmd.Parameters.AddWithValue("@PbulishDate", objupdate.PbulishDate);
                cmd.Parameters.AddWithValue("@Quantity", objupdate.Quantity);
                cmd.Parameters.AddWithValue("@BookRentAmount", objupdate.BookRentAmount);
                cmd.Parameters.AddWithValue("@ImgPath", objupdate.ImgPath);
                cmd.Parameters.AddWithValue("@Available", objupdate.Available);
                cmd.Parameters.AddWithValue("@EmployeeId", objupdate.EmployeeId);
                cmd.Parameters.AddWithValue("@BorrowerId", objupdate.BorrowerId);
                cmd.Parameters.AddWithValue("@BookId", objupdate.BookId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblPurchaseId.Text = "";
                    MessageBox.Show("Update Info successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Update Insertion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                LoadGridView();
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Please select Purchase Id!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbookid.Text))
            {
                bookclass objdelete = new bookclass();
                objdelete.BookId = Convert.ToInt16(txtbookid.Text);
                string sqlQuery = "DELETE FROM  Book WHERE BookId=@BookId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@BookId", objdelete.BookId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    txtbookid.Text = "";
                    MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                LoadGridView();
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Please select Book Id!", "Warning", MessageBoxButtons.OK);
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            List<BookViewModel> list = new List<BookViewModel>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string SqlQuery = "SELECT b.BookId, b.BookName, b.AuthorName, b.Publisher,b.PbulishDate,b.Quantity,b.BookRentAmount,b.Available,b.EmployeeId,b.BorrowerId, br.FirstName,br.LastName,br.MiddleName,em.FullName,em.EmpAddress,em.EmpEmail,em.ImagePath, b.ImgPath   FROM Book b JOIN Borrowers br ON b.BorrowerId=br.BorrowerId JOIN Employee em ON b.EmployeeId=em.EmployeeId";
                SqlDataAdapter sda = new SqlDataAdapter(SqlQuery, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BookViewModel objbookview = new BookViewModel();
                    objbookview.BookId = Convert.ToInt32(dt.Rows[i]["BookId"].ToString());
                    objbookview.BookName = dt.Rows[i]["BookName"].ToString();
                    objbookview.AuthorName = dt.Rows[i]["AuthorName"].ToString();
                    objbookview.Publisiher = dt.Rows[i]["Publisher"].ToString();
                    objbookview.PbulishDate = Convert.ToDateTime(dt.Rows[i]["PbulishDate"].ToString());
                    objbookview.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                    objbookview.BookRentAmount = Convert.ToDecimal(dt.Rows[i]["BookRentAmount"].ToString());
                    objbookview.Gender = Convert.ToBoolean(dt.Rows[i]["Available"].ToString());
                    objbookview.EmployeeId = Convert.ToInt32(dt.Rows[i]["EmployeeId"].ToString());
                    objbookview.BorrowerId = Convert.ToInt32(dt.Rows[i]["BorrowerId"].ToString());
                    objbookview.FirstName = dt.Rows[i]["FirstName"].ToString();
                    objbookview.LastName = dt.Rows[i]["LastName"].ToString();
                    objbookview.MiddleName = dt.Rows[i]["MiddleName"].ToString();
                    
                    objbookview.FullName = dt.Rows[i]["FullName"].ToString();
                    objbookview.EmpAddress = dt.Rows[i]["EmpAddress"].ToString();
                    objbookview.EmpEmail = dt.Rows[i]["EmpEmail"].ToString();
                    objbookview.ImagePath = dt.Rows[i]["ImagePath"].ToString();
                    objbookview.ImgPath = dt.Rows[i]["ImgPath"].ToString();    
                    list.Add(objbookview);
                }
            }
            using (BookRerports form = new BookRerports(list))
            {
                form.ShowDialog();
            }
        }
       
        private void dgvgreed_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvgreed.Rows[cellId];
                txtbookid.Text = row.Cells[0].Value.ToString();
                txtbookname.Text = row.Cells[1].Value.ToString();
                txtuthorname.Text = row.Cells[2].Value.ToString();
                txtpublisher.Text = row.Cells[3].Value.ToString();
                dtppublishDate.Text = row.Cells[4].Value.ToString();
                txtQuantity.Text = row.Cells[5].Value.ToString();
                txtrent.Text = (row.Cells[6].Value.ToString());
                if (row.Cells[7].Value.ToString() == "True")
                {
                    radiomale.Checked = true;
                }
                else if (row.Cells[7].Value.ToString() == "false")
                {
                    radiofemale.Checked = true;
                }
                cmbbor.Text = row.Cells[10].Value.ToString();
               
                if (imagePathFromData == "No Image")
                {
                    pbbook.Image = Resources.noimage;
                }
                byte[] data = (byte[])row.Cells[13].Value;
                MemoryStream stream = new MemoryStream(data);
                pbbook.Image = Image.FromStream(stream);
                imagePathFromData = row.Cells[12].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnsavebook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbor.Text) == true)
            {
                txtbor.Focus();
                errorProvider1.SetError(this.txtbor, "Please Enter BorrowerName");
                ClearMethod();
            }
            else
            {
                BORROW objbor = new BORROW();
                objbor.FirstName = txtbor.Text;
                string sqlQuery = "Insert INTO Borrowers (FirstName) VALUES ('" + objbor.FirstName + "')";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Borrower added successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Borrower Insertion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                LoadBook();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainForm objmain = new MainForm();
            this.Hide();
            objmain.ShowDialog();
        }

        private void dgvgreed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
