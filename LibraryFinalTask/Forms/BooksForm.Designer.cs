namespace LibraryFinalTask.Forms
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconRefresh = new System.Windows.Forms.PictureBox();
            this.rBtnStatusDisabled = new System.Windows.Forms.RadioButton();
            this.rBtnStatusActive = new System.Windows.Forms.RadioButton();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblErrorCount = new System.Windows.Forms.Label();
            this.lblErrorRent = new System.Windows.Forms.Label();
            this.lblErrorSale = new System.Windows.Forms.Label();
            this.lblErrorLang = new System.Windows.Forms.Label();
            this.lblErrorAuthor = new System.Windows.Forms.Label();
            this.lblErrorGenre = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ntxtCount = new System.Windows.Forms.NumericUpDown();
            this.ntxtRent = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.ntxtSale = new System.Windows.Forms.NumericUpDown();
            this.iconAddLang = new System.Windows.Forms.PictureBox();
            this.iconAddAuthor = new System.Windows.Forms.PictureBox();
            this.iconAddGenre = new System.Windows.Forms.PictureBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitleBook = new System.Windows.Forms.Label();
            this.lblSelectedBookName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.iconRefresh);
            this.panel1.Controls.Add(this.rBtnStatusDisabled);
            this.panel1.Controls.Add(this.rBtnStatusActive);
            this.panel1.Controls.Add(this.lblErrorStatus);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblErrorCount);
            this.panel1.Controls.Add(this.lblErrorRent);
            this.panel1.Controls.Add(this.lblErrorSale);
            this.panel1.Controls.Add(this.lblErrorLang);
            this.panel1.Controls.Add(this.lblErrorAuthor);
            this.panel1.Controls.Add(this.lblErrorGenre);
            this.panel1.Controls.Add(this.lblErrorName);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.ntxtCount);
            this.panel1.Controls.Add(this.ntxtRent);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.ntxtSale);
            this.panel1.Controls.Add(this.iconAddLang);
            this.panel1.Controls.Add(this.iconAddAuthor);
            this.panel1.Controls.Add(this.iconAddGenre);
            this.panel1.Controls.Add(this.cmbLanguage);
            this.panel1.Controls.Add(this.cmbAuthor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbGenre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(814, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 511);
            this.panel1.TabIndex = 0;
            // 
            // iconRefresh
            // 
            this.iconRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRefresh.Image = ((System.Drawing.Image)(resources.GetObject("iconRefresh.Image")));
            this.iconRefresh.Location = new System.Drawing.Point(318, 20);
            this.iconRefresh.Name = "iconRefresh";
            this.iconRefresh.Size = new System.Drawing.Size(39, 25);
            this.iconRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRefresh.TabIndex = 46;
            this.iconRefresh.TabStop = false;
            this.iconRefresh.Click += new System.EventHandler(this.IconRefresh_Click);
            // 
            // rBtnStatusDisabled
            // 
            this.rBtnStatusDisabled.AutoSize = true;
            this.rBtnStatusDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rBtnStatusDisabled.Location = new System.Drawing.Point(183, 382);
            this.rBtnStatusDisabled.Name = "rBtnStatusDisabled";
            this.rBtnStatusDisabled.Size = new System.Drawing.Size(66, 17);
            this.rBtnStatusDisabled.TabIndex = 43;
            this.rBtnStatusDisabled.TabStop = true;
            this.rBtnStatusDisabled.Text = "Disabled";
            this.rBtnStatusDisabled.UseVisualStyleBackColor = true;
            // 
            // rBtnStatusActive
            // 
            this.rBtnStatusActive.AutoSize = true;
            this.rBtnStatusActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rBtnStatusActive.Location = new System.Drawing.Point(92, 382);
            this.rBtnStatusActive.Name = "rBtnStatusActive";
            this.rBtnStatusActive.Size = new System.Drawing.Size(55, 17);
            this.rBtnStatusActive.TabIndex = 42;
            this.rBtnStatusActive.TabStop = true;
            this.rBtnStatusActive.Text = "Active";
            this.rBtnStatusActive.UseVisualStyleBackColor = true;
            // 
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStatus.Location = new System.Drawing.Point(133, 402);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(72, 13);
            this.lblErrorStatus.TabIndex = 45;
            this.lblErrorStatus.Text = "*Select status";
            this.lblErrorStatus.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label10.Location = new System.Drawing.Point(32, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Status";
            // 
            // lblErrorCount
            // 
            this.lblErrorCount.AutoSize = true;
            this.lblErrorCount.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCount.Location = new System.Drawing.Point(89, 359);
            this.lblErrorCount.Name = "lblErrorCount";
            this.lblErrorCount.Size = new System.Drawing.Size(93, 13);
            this.lblErrorCount.TabIndex = 15;
            this.lblErrorCount.Text = "*Enter book count";
            this.lblErrorCount.Visible = false;
            // 
            // lblErrorRent
            // 
            this.lblErrorRent.AutoSize = true;
            this.lblErrorRent.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRent.Location = new System.Drawing.Point(89, 311);
            this.lblErrorRent.Name = "lblErrorRent";
            this.lblErrorRent.Size = new System.Drawing.Size(103, 13);
            this.lblErrorRent.TabIndex = 15;
            this.lblErrorRent.Text = "*Enter price for Rent";
            this.lblErrorRent.Visible = false;
            // 
            // lblErrorSale
            // 
            this.lblErrorSale.AutoSize = true;
            this.lblErrorSale.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSale.Location = new System.Drawing.Point(89, 266);
            this.lblErrorSale.Name = "lblErrorSale";
            this.lblErrorSale.Size = new System.Drawing.Size(101, 13);
            this.lblErrorSale.TabIndex = 15;
            this.lblErrorSale.Text = "*Enter price for Sale";
            this.lblErrorSale.Visible = false;
            // 
            // lblErrorLang
            // 
            this.lblErrorLang.AutoSize = true;
            this.lblErrorLang.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLang.Location = new System.Drawing.Point(89, 221);
            this.lblErrorLang.Name = "lblErrorLang";
            this.lblErrorLang.Size = new System.Drawing.Size(88, 13);
            this.lblErrorLang.TabIndex = 15;
            this.lblErrorLang.Text = "*Select language";
            this.lblErrorLang.Visible = false;
            // 
            // lblErrorAuthor
            // 
            this.lblErrorAuthor.AutoSize = true;
            this.lblErrorAuthor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAuthor.Location = new System.Drawing.Point(89, 175);
            this.lblErrorAuthor.Name = "lblErrorAuthor";
            this.lblErrorAuthor.Size = new System.Drawing.Size(74, 13);
            this.lblErrorAuthor.TabIndex = 15;
            this.lblErrorAuthor.Text = "*Select author";
            this.lblErrorAuthor.Visible = false;
            // 
            // lblErrorGenre
            // 
            this.lblErrorGenre.AutoSize = true;
            this.lblErrorGenre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGenre.Location = new System.Drawing.Point(89, 129);
            this.lblErrorGenre.Name = "lblErrorGenre";
            this.lblErrorGenre.Size = new System.Drawing.Size(71, 13);
            this.lblErrorGenre.TabIndex = 15;
            this.lblErrorGenre.Text = "*Select genre";
            this.lblErrorGenre.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(89, 83);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(65, 13);
            this.lblErrorName.TabIndex = 15;
            this.lblErrorName.Text = "*Enter name";
            this.lblErrorName.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancel.Location = new System.Drawing.Point(194, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Reset";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ntxtCount
            // 
            this.ntxtCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtCount.Location = new System.Drawing.Point(92, 336);
            this.ntxtCount.Name = "ntxtCount";
            this.ntxtCount.Size = new System.Drawing.Size(196, 20);
            this.ntxtCount.TabIndex = 6;
            // 
            // ntxtRent
            // 
            this.ntxtRent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtRent.Location = new System.Drawing.Point(92, 288);
            this.ntxtRent.Name = "ntxtRent";
            this.ntxtRent.Size = new System.Drawing.Size(196, 20);
            this.ntxtRent.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnCreate.Location = new System.Drawing.Point(92, 446);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 35);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // ntxtSale
            // 
            this.ntxtSale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtSale.Location = new System.Drawing.Point(92, 243);
            this.ntxtSale.Name = "ntxtSale";
            this.ntxtSale.Size = new System.Drawing.Size(196, 20);
            this.ntxtSale.TabIndex = 5;
            // 
            // iconAddLang
            // 
            this.iconAddLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAddLang.Image = ((System.Drawing.Image)(resources.GetObject("iconAddLang.Image")));
            this.iconAddLang.Location = new System.Drawing.Point(297, 193);
            this.iconAddLang.Name = "iconAddLang";
            this.iconAddLang.Size = new System.Drawing.Size(23, 23);
            this.iconAddLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconAddLang.TabIndex = 3;
            this.iconAddLang.TabStop = false;
            this.iconAddLang.Click += new System.EventHandler(this.IconAddLang_Click);
            // 
            // iconAddAuthor
            // 
            this.iconAddAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("iconAddAuthor.Image")));
            this.iconAddAuthor.Location = new System.Drawing.Point(297, 147);
            this.iconAddAuthor.Name = "iconAddAuthor";
            this.iconAddAuthor.Size = new System.Drawing.Size(23, 23);
            this.iconAddAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconAddAuthor.TabIndex = 3;
            this.iconAddAuthor.TabStop = false;
            this.iconAddAuthor.Click += new System.EventHandler(this.IconAddAuthor_Click);
            // 
            // iconAddGenre
            // 
            this.iconAddGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAddGenre.Image = ((System.Drawing.Image)(resources.GetObject("iconAddGenre.Image")));
            this.iconAddGenre.Location = new System.Drawing.Point(297, 103);
            this.iconAddGenre.Name = "iconAddGenre";
            this.iconAddGenre.Size = new System.Drawing.Size(23, 23);
            this.iconAddGenre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconAddGenre.TabIndex = 3;
            this.iconAddGenre.TabStop = false;
            this.iconAddGenre.Click += new System.EventHandler(this.IconAddGenre_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(92, 197);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(196, 21);
            this.cmbLanguage.TabIndex = 4;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(92, 151);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(196, 21);
            this.cmbAuthor.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(35, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Count";
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(92, 105);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(196, 21);
            this.cmbGenre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(13, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rent Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(15, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sale Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(92, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(38, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(38, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblTitleBook
            // 
            this.lblTitleBook.AutoSize = true;
            this.lblTitleBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleBook.Location = new System.Drawing.Point(12, 27);
            this.lblTitleBook.Name = "lblTitleBook";
            this.lblTitleBook.Size = new System.Drawing.Size(82, 13);
            this.lblTitleBook.TabIndex = 3;
            this.lblTitleBook.Text = "Selected book :";
            this.lblTitleBook.Visible = false;
            // 
            // lblSelectedBookName
            // 
            this.lblSelectedBookName.AutoSize = true;
            this.lblSelectedBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedBookName.Location = new System.Drawing.Point(95, 27);
            this.lblSelectedBookName.Name = "lblSelectedBookName";
            this.lblSelectedBookName.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedBookName.TabIndex = 4;
            this.lblSelectedBookName.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(163)))), ((int)(((byte)(30)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(647, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(733, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Status";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Rent Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sale Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Count";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Language";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Author";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.Location = new System.Drawing.Point(12, 57);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooks.Size = new System.Drawing.Size(796, 442);
            this.dgvBooks.TabIndex = 1;
            this.dgvBooks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseDoubleClick);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1174, 511);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelectedBookName);
            this.Controls.Add(this.lblTitleBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library App - Books";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAddGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconAddGenre;
        private System.Windows.Forms.PictureBox iconAddAuthor;
        private System.Windows.Forms.NumericUpDown ntxtRent;
        private System.Windows.Forms.NumericUpDown ntxtSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox iconAddLang;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblErrorRent;
        private System.Windows.Forms.Label lblErrorSale;
        private System.Windows.Forms.Label lblErrorLang;
        private System.Windows.Forms.Label lblErrorAuthor;
        private System.Windows.Forms.Label lblErrorGenre;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.Label lblSelectedBookName;
        private System.Windows.Forms.RadioButton rBtnStatusDisabled;
        private System.Windows.Forms.RadioButton rBtnStatusActive;
        private System.Windows.Forms.Label lblErrorStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox iconRefresh;
        private System.Windows.Forms.Label lblErrorCount;
        private System.Windows.Forms.NumericUpDown ntxtCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}