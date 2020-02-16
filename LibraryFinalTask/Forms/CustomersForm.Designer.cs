namespace LibraryFinalTask.Forms
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.iconBackspace = new System.Windows.Forms.PictureBox();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblErrorSearchFilter = new System.Windows.Forms.Label();
            this.lblSelectedFullname = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTitleSelected = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.iconGoBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblErrorSurname = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.rBtnStatusDisabled = new System.Windows.Forms.RadioButton();
            this.rBtnStatusActive = new System.Windows.Forms.RadioButton();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.pnlHeader.Controls.Add(this.iconBackspace);
            this.pnlHeader.Controls.Add(this.cmbSearchCategory);
            this.pnlHeader.Controls.Add(this.iconSearch);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.lblErrorSearchFilter);
            this.pnlHeader.Controls.Add(this.lblSelectedFullname);
            this.pnlHeader.Controls.Add(this.label13);
            this.pnlHeader.Controls.Add(this.lblTitleSelected);
            this.pnlHeader.Controls.Add(this.btnUpdate);
            this.pnlHeader.Controls.Add(this.btnDelete);
            this.pnlHeader.Controls.Add(this.iconGoBack);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // iconBackspace
            // 
            this.iconBackspace.Image = ((System.Drawing.Image)(resources.GetObject("iconBackspace.Image")));
            this.iconBackspace.Location = new System.Drawing.Point(875, 55);
            this.iconBackspace.Name = "iconBackspace";
            this.iconBackspace.Size = new System.Drawing.Size(20, 20);
            this.iconBackspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBackspace.TabIndex = 47;
            this.iconBackspace.TabStop = false;
            this.iconBackspace.Click += new System.EventHandler(this.IconBackspace_Click);
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Items.AddRange(new object[] {
            "Name",
            "Surname",
            "Fullname",
            "Email",
            "Phone"});
            this.cmbSearchCategory.Location = new System.Drawing.Point(657, 56);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(70, 21);
            this.cmbSearchCategory.TabIndex = 45;
            this.cmbSearchCategory.TabStop = false;
            // 
            // iconSearch
            // 
            this.iconSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSearch.Image = ((System.Drawing.Image)(resources.GetObject("iconSearch.Image")));
            this.iconSearch.Location = new System.Drawing.Point(901, 55);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(21, 21);
            this.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSearch.TabIndex = 43;
            this.iconSearch.TabStop = false;
            this.iconSearch.Click += new System.EventHandler(this.IconSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(731, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblErrorSearchFilter
            // 
            this.lblErrorSearchFilter.AutoSize = true;
            this.lblErrorSearchFilter.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSearchFilter.Location = new System.Drawing.Point(654, 80);
            this.lblErrorSearchFilter.Name = "lblErrorSearchFilter";
            this.lblErrorSearchFilter.Size = new System.Drawing.Size(61, 13);
            this.lblErrorSearchFilter.TabIndex = 46;
            this.lblErrorSearchFilter.Text = "*select filter";
            this.lblErrorSearchFilter.Visible = false;
            // 
            // lblSelectedFullname
            // 
            this.lblSelectedFullname.AutoSize = true;
            this.lblSelectedFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedFullname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectedFullname.Location = new System.Drawing.Point(426, 21);
            this.lblSelectedFullname.Name = "lblSelectedFullname";
            this.lblSelectedFullname.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedFullname.TabIndex = 41;
            this.lblSelectedFullname.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(607, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Search :";
            // 
            // lblTitleSelected
            // 
            this.lblTitleSelected.AutoSize = true;
            this.lblTitleSelected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleSelected.Location = new System.Drawing.Point(371, 21);
            this.lblTitleSelected.Name = "lblTitleSelected";
            this.lblTitleSelected.Size = new System.Drawing.Size(55, 13);
            this.lblTitleSelected.TabIndex = 41;
            this.lblTitleSelected.Text = "Selected :";
            this.lblTitleSelected.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(163)))), ((int)(((byte)(30)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(374, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 39;
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
            this.btnDelete.Location = new System.Drawing.Point(456, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // iconGoBack
            // 
            this.iconGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconGoBack.Image = ((System.Drawing.Image)(resources.GetObject("iconGoBack.Image")));
            this.iconGoBack.Location = new System.Drawing.Point(1008, 23);
            this.iconGoBack.Name = "iconGoBack";
            this.iconGoBack.Size = new System.Drawing.Size(64, 50);
            this.iconGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconGoBack.TabIndex = 2;
            this.iconGoBack.TabStop = false;
            this.iconGoBack.Click += new System.EventHandler(this.IconGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(145, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlInputs
            // 
            this.pnlInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.pnlInputs.Controls.Add(this.btnReset);
            this.pnlInputs.Controls.Add(this.btnCreate);
            this.pnlInputs.Controls.Add(this.lblErrorSurname);
            this.pnlInputs.Controls.Add(this.lblErrorName);
            this.pnlInputs.Controls.Add(this.txtSurname);
            this.pnlInputs.Controls.Add(this.label41);
            this.pnlInputs.Controls.Add(this.txtName);
            this.pnlInputs.Controls.Add(this.label52);
            this.pnlInputs.Controls.Add(this.rBtnStatusDisabled);
            this.pnlInputs.Controls.Add(this.rBtnStatusActive);
            this.pnlInputs.Controls.Add(this.lblErrorStatus);
            this.pnlInputs.Controls.Add(this.lblErrorPhone);
            this.pnlInputs.Controls.Add(this.lblErrorEmail);
            this.pnlInputs.Controls.Add(this.txtPhone);
            this.pnlInputs.Controls.Add(this.label10);
            this.pnlInputs.Controls.Add(this.label4);
            this.pnlInputs.Controls.Add(this.txtEmail);
            this.pnlInputs.Controls.Add(this.label5);
            this.pnlInputs.Location = new System.Drawing.Point(0, 100);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(325, 350);
            this.pnlInputs.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 11F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnReset.Location = new System.Drawing.Point(212, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 35);
            this.btnReset.TabIndex = 47;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCreate.Location = new System.Drawing.Point(117, 269);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 35);
            this.btnCreate.TabIndex = 48;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblErrorSurname
            // 
            this.lblErrorSurname.AutoSize = true;
            this.lblErrorSurname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSurname.Location = new System.Drawing.Point(114, 105);
            this.lblErrorSurname.Name = "lblErrorSurname";
            this.lblErrorSurname.Size = new System.Drawing.Size(79, 13);
            this.lblErrorSurname.TabIndex = 46;
            this.lblErrorSurname.Text = "*Enter surname";
            this.lblErrorSurname.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(114, 61);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(65, 13);
            this.lblErrorName.TabIndex = 46;
            this.lblErrorName.Text = "*Enter name";
            this.lblErrorName.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSurname.Location = new System.Drawing.Point(117, 82);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(180, 20);
            this.txtSurname.TabIndex = 44;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label41.Location = new System.Drawing.Point(35, 85);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 16);
            this.label41.TabIndex = 45;
            this.label41.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(117, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 44;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label52.Location = new System.Drawing.Point(38, 38);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(49, 16);
            this.label52.TabIndex = 45;
            this.label52.Text = "Name";
            // 
            // rBtnStatusDisabled
            // 
            this.rBtnStatusDisabled.AutoSize = true;
            this.rBtnStatusDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rBtnStatusDisabled.Location = new System.Drawing.Point(208, 214);
            this.rBtnStatusDisabled.Name = "rBtnStatusDisabled";
            this.rBtnStatusDisabled.Size = new System.Drawing.Size(66, 17);
            this.rBtnStatusDisabled.TabIndex = 37;
            this.rBtnStatusDisabled.TabStop = true;
            this.rBtnStatusDisabled.Text = "Disabled";
            this.rBtnStatusDisabled.UseVisualStyleBackColor = true;
            // 
            // rBtnStatusActive
            // 
            this.rBtnStatusActive.AutoSize = true;
            this.rBtnStatusActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rBtnStatusActive.Location = new System.Drawing.Point(117, 214);
            this.rBtnStatusActive.Name = "rBtnStatusActive";
            this.rBtnStatusActive.Size = new System.Drawing.Size(55, 17);
            this.rBtnStatusActive.TabIndex = 36;
            this.rBtnStatusActive.TabStop = true;
            this.rBtnStatusActive.Text = "Active";
            this.rBtnStatusActive.UseVisualStyleBackColor = true;
            // 
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStatus.Location = new System.Drawing.Point(158, 234);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(72, 13);
            this.lblErrorStatus.TabIndex = 41;
            this.lblErrorStatus.Text = "*Select status";
            this.lblErrorStatus.Visible = false;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(114, 193);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(107, 13);
            this.lblErrorPhone.TabIndex = 42;
            this.lblErrorPhone.Text = "*Enter phone number";
            this.lblErrorPhone.Visible = false;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(114, 149);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(63, 13);
            this.lblErrorEmail.TabIndex = 43;
            this.lblErrorEmail.Text = "*Enter email";
            this.lblErrorEmail.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.Location = new System.Drawing.Point(117, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 20);
            this.txtPhone.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label10.Location = new System.Drawing.Point(35, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(35, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(117, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(35, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Email";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvCustomers.Location = new System.Drawing.Point(336, 113);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(740, 320);
            this.dgvCustomers.TabIndex = 3;
            this.dgvCustomers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomers_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Orders";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSelectedFullname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTitleSelected;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox iconGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.RadioButton rBtnStatusDisabled;
        private System.Windows.Forms.RadioButton rBtnStatusActive;
        private System.Windows.Forms.Label lblErrorStatus;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorSurname;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Label lblErrorSearchFilter;
        private System.Windows.Forms.PictureBox iconBackspace;
    }
}