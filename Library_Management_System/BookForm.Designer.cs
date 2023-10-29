namespace Library_Management_System
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.lblPurchaseId = new System.Windows.Forms.Label();
            this.txtbor = new System.Windows.Forms.TextBox();
            this.lblborrs = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtppublishDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.dgvgreed = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsavebook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbor = new System.Windows.Forms.ComboBox();
            this.radiofemale = new System.Windows.Forms.RadioButton();
            this.radiomale = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbbook = new System.Windows.Forms.PictureBox();
            this.lblpublish = new System.Windows.Forms.Label();
            this.lblpublisher = new System.Windows.Forms.Label();
            this.lblauthor = new System.Windows.Forms.Label();
            this.lblborrower = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.txtrent = new System.Windows.Forms.TextBox();
            this.iblrent = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.txtuthorname = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.lblbookid = new System.Windows.Forms.Label();
            this.lblbook = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgreed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbbook)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPurchaseId
            // 
            this.lblPurchaseId.AutoSize = true;
            this.lblPurchaseId.Location = new System.Drawing.Point(138, 17);
            this.lblPurchaseId.Name = "lblPurchaseId";
            this.lblPurchaseId.Size = new System.Drawing.Size(0, 13);
            this.lblPurchaseId.TabIndex = 26;
            this.lblPurchaseId.Visible = false;
            // 
            // txtbor
            // 
            this.txtbor.Location = new System.Drawing.Point(122, 17);
            this.txtbor.Name = "txtbor";
            this.txtbor.Size = new System.Drawing.Size(285, 20);
            this.txtbor.TabIndex = 1;
            // 
            // lblborrs
            // 
            this.lblborrs.AutoSize = true;
            this.lblborrs.Location = new System.Drawing.Point(7, 20);
            this.lblborrs.Name = "lblborrs";
            this.lblborrs.Size = new System.Drawing.Size(57, 13);
            this.lblborrs.TabIndex = 0;
            this.lblborrs.Text = "Borrower";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(28, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 30);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(249, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Azure;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(936, 379);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(166, 37);
            this.btnReport.TabIndex = 18;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtppublishDate
            // 
            this.dtppublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider1.SetIconAlignment(this.dtppublishDate, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.dtppublishDate.Location = new System.Drawing.Point(143, 186);
            this.dtppublishDate.Name = "dtppublishDate";
            this.dtppublishDate.Size = new System.Drawing.Size(152, 20);
            this.dtppublishDate.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(140, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 32);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(168, 14);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmount.TabIndex = 23;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(943, 34);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(78, 18);
            this.lblEmployeeName.TabIndex = 21;
            this.lblEmployeeName.Text = "Unknown";
            // 
            // dgvgreed
            // 
            this.dgvgreed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvgreed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvgreed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgreed.Location = new System.Drawing.Point(369, 67);
            this.dgvgreed.Name = "dgvgreed";
            this.dgvgreed.RowHeadersWidth = 51;
            this.dgvgreed.Size = new System.Drawing.Size(733, 280);
            this.dgvgreed.TabIndex = 19;
            this.dgvgreed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgreed_CellClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsavebook);
            this.groupBox2.Controls.Add(this.txtbor);
            this.groupBox2.Controls.Add(this.lblborrs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(345, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 126);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrower";
            // 
            // btnsavebook
            // 
            this.btnsavebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavebook.Location = new System.Drawing.Point(441, 15);
            this.btnsavebook.Name = "btnsavebook";
            this.btnsavebook.Size = new System.Drawing.Size(75, 23);
            this.btnsavebook.TabIndex = 2;
            this.btnsavebook.Text = "Add";
            this.btnsavebook.UseVisualStyleBackColor = true;
            this.btnsavebook.Click += new System.EventHandler(this.btnsavebook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbbor);
            this.groupBox1.Controls.Add(this.radiofemale);
            this.groupBox1.Controls.Add(this.radiomale);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.pbbook);
            this.groupBox1.Controls.Add(this.dtppublishDate);
            this.groupBox1.Controls.Add(this.lblpublish);
            this.groupBox1.Controls.Add(this.lblpublisher);
            this.groupBox1.Controls.Add(this.lblauthor);
            this.groupBox1.Controls.Add(this.lblborrower);
            this.groupBox1.Controls.Add(this.lblbookname);
            this.groupBox1.Controls.Add(this.txtrent);
            this.groupBox1.Controls.Add(this.iblrent);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblgender);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.txtpublisher);
            this.groupBox1.Controls.Add(this.txtuthorname);
            this.groupBox1.Controls.Add(this.txtbookname);
            this.groupBox1.Controls.Add(this.txtbookid);
            this.groupBox1.Controls.Add(this.lblbookid);
            this.groupBox1.Location = new System.Drawing.Point(28, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 467);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cmbbor
            // 
            this.cmbbor.FormattingEnabled = true;
            this.cmbbor.Location = new System.Drawing.Point(143, 88);
            this.cmbbor.Name = "cmbbor";
            this.cmbbor.Size = new System.Drawing.Size(151, 21);
            this.cmbbor.TabIndex = 9;
            // 
            // radiofemale
            // 
            this.radiofemale.AutoSize = true;
            this.radiofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofemale.Location = new System.Drawing.Point(230, 300);
            this.radiofemale.Name = "radiofemale";
            this.radiofemale.Size = new System.Drawing.Size(39, 17);
            this.radiofemale.TabIndex = 8;
            this.radiofemale.TabStop = true;
            this.radiofemale.Text = "No";
            this.radiofemale.UseVisualStyleBackColor = true;
            this.radiofemale.CheckedChanged += new System.EventHandler(this.radiofemale_CheckedChanged);
            // 
            // radiomale
            // 
            this.radiomale.AutoSize = true;
            this.radiomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiomale.Location = new System.Drawing.Point(162, 300);
            this.radiomale.Name = "radiomale";
            this.radiomale.Size = new System.Drawing.Size(43, 17);
            this.radiomale.TabIndex = 8;
            this.radiomale.TabStop = true;
            this.radiomale.Text = "Yes";
            this.radiomale.UseVisualStyleBackColor = true;
            this.radiomale.CheckedChanged += new System.EventHandler(this.radiomale_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(162, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "  Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.Location = new System.Drawing.Point(162, 345);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse....";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbbook
            // 
            this.pbbook.Location = new System.Drawing.Point(10, 337);
            this.pbbook.Name = "pbbook";
            this.pbbook.Size = new System.Drawing.Size(100, 81);
            this.pbbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbook.TabIndex = 5;
            this.pbbook.TabStop = false;
            // 
            // lblpublish
            // 
            this.lblpublish.AutoSize = true;
            this.lblpublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblpublish.Location = new System.Drawing.Point(6, 191);
            this.lblpublish.Name = "lblpublish";
            this.lblpublish.Size = new System.Drawing.Size(103, 18);
            this.lblpublish.TabIndex = 1;
            this.lblpublish.Text = "Publish Date";
            // 
            // lblpublisher
            // 
            this.lblpublisher.AutoSize = true;
            this.lblpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblpublisher.Location = new System.Drawing.Point(6, 160);
            this.lblpublisher.Name = "lblpublisher";
            this.lblpublisher.Size = new System.Drawing.Size(78, 18);
            this.lblpublisher.TabIndex = 1;
            this.lblpublisher.Text = "Publisher";
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblauthor.Location = new System.Drawing.Point(5, 125);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(116, 18);
            this.lblauthor.TabIndex = 1;
            this.lblauthor.Text = "Author Name :";
            this.lblauthor.Click += new System.EventHandler(this.lblauthor_Click);
            // 
            // lblborrower
            // 
            this.lblborrower.AutoSize = true;
            this.lblborrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblborrower.Location = new System.Drawing.Point(7, 88);
            this.lblborrower.Name = "lblborrower";
            this.lblborrower.Size = new System.Drawing.Size(137, 18);
            this.lblborrower.TabIndex = 1;
            this.lblborrower.Text = "Borrower Name :";
            // 
            // lblbookname
            // 
            this.lblbookname.AutoSize = true;
            this.lblbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblbookname.Location = new System.Drawing.Point(7, 54);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(107, 18);
            this.lblbookname.TabIndex = 1;
            this.lblbookname.Text = "Book Name :";
            // 
            // txtrent
            // 
            this.txtrent.Location = new System.Drawing.Point(143, 260);
            this.txtrent.Name = "txtrent";
            this.txtrent.Size = new System.Drawing.Size(153, 20);
            this.txtrent.TabIndex = 2;
            // 
            // iblrent
            // 
            this.iblrent.AutoSize = true;
            this.iblrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.iblrent.Location = new System.Drawing.Point(7, 264);
            this.iblrent.Name = "iblrent";
            this.iblrent.Size = new System.Drawing.Size(97, 18);
            this.iblrent.TabIndex = 1;
            this.iblrent.Text = "Book Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(143, 225);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(153, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblgender.Location = new System.Drawing.Point(9, 300);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(138, 18);
            this.lblgender.TabIndex = 1;
            this.lblgender.Text = "Available Books :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(7, 227);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 18);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity :";
            // 
            // txtpublisher
            // 
            this.txtpublisher.Location = new System.Drawing.Point(143, 160);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(153, 20);
            this.txtpublisher.TabIndex = 2;
            // 
            // txtuthorname
            // 
            this.txtuthorname.Location = new System.Drawing.Point(143, 124);
            this.txtuthorname.Name = "txtuthorname";
            this.txtuthorname.Size = new System.Drawing.Size(151, 20);
            this.txtuthorname.TabIndex = 2;
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(143, 52);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(151, 20);
            this.txtbookname.TabIndex = 2;
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(143, 18);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.ReadOnly = true;
            this.txtbookid.Size = new System.Drawing.Size(152, 20);
            this.txtbookid.TabIndex = 2;
            // 
            // lblbookid
            // 
            this.lblbookid.AutoSize = true;
            this.lblbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblbookid.Location = new System.Drawing.Point(7, 20);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(81, 18);
            this.lblbookid.TabIndex = 1;
            this.lblbookid.Text = "Book Id  :";
            // 
            // lblbook
            // 
            this.lblbook.AutoSize = true;
            this.lblbook.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbook.ForeColor = System.Drawing.Color.Blue;
            this.lblbook.Location = new System.Drawing.Point(388, 0);
            this.lblbook.Name = "lblbook";
            this.lblbook.Size = new System.Drawing.Size(513, 39);
            this.lblbook.TabIndex = 14;
            this.lblbook.Text = "Library Book Table  Dashbord";
            this.lblbook.Click += new System.EventHandler(this.lblbook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Location = new System.Drawing.Point(1, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 59);
            this.panel1.TabIndex = 27;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Cyan;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(531, 14);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(58, 42);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnback.TabIndex = 41;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1133, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPurchaseId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.dgvgreed);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblbook);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgreed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbbook)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchaseId;
        private System.Windows.Forms.TextBox txtbor;
        private System.Windows.Forms.Label lblborrs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.DataGridView dgvgreed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsavebook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbbook;
        private System.Windows.Forms.DateTimePicker dtppublishDate;
        private System.Windows.Forms.Label lblpublish;
        private System.Windows.Forms.Label lblpublisher;
        private System.Windows.Forms.TextBox txtrent;
        private System.Windows.Forms.Label iblrent;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label lblbook;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.TextBox txtuthorname;
        private System.Windows.Forms.TextBox txtpublisher;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.RadioButton radiomale;
        private System.Windows.Forms.RadioButton radiofemale;
        private System.Windows.Forms.Label lblborrower;
        private System.Windows.Forms.Label lblbookname;
        private System.Windows.Forms.Label lblbookid;
        private System.Windows.Forms.ComboBox cmbbor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnback;
    }
}