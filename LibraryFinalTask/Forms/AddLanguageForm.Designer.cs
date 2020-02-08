namespace LibraryFinalTask.Forms
{
    partial class AddLanguageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLanguageForm));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rBtnStatusDisabled = new System.Windows.Forms.RadioButton();
            this.rBtnStatusActive = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTitleSelected = new System.Windows.Forms.Label();
            this.lblSelectedFullname = new System.Windows.Forms.Label();
            this.iconBackspace = new System.Windows.Forms.PictureBox();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 11F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnReset.Location = new System.Drawing.Point(186, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 30);
            this.btnReset.TabIndex = 69;
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
            this.btnCreate.Location = new System.Drawing.Point(99, 289);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 33);
            this.btnCreate.TabIndex = 70;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // rBtnStatusDisabled
            // 
            this.rBtnStatusDisabled.AutoSize = true;
            this.rBtnStatusDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rBtnStatusDisabled.Location = new System.Drawing.Point(190, 216);
            this.rBtnStatusDisabled.Name = "rBtnStatusDisabled";
            this.rBtnStatusDisabled.Size = new System.Drawing.Size(66, 17);
            this.rBtnStatusDisabled.TabIndex = 66;
            this.rBtnStatusDisabled.TabStop = true;
            this.rBtnStatusDisabled.Text = "Disabled";
            this.rBtnStatusDisabled.UseVisualStyleBackColor = true;
            // 
            // rBtnStatusActive
            // 
            this.rBtnStatusActive.AutoSize = true;
            this.rBtnStatusActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rBtnStatusActive.Location = new System.Drawing.Point(99, 216);
            this.rBtnStatusActive.Name = "rBtnStatusActive";
            this.rBtnStatusActive.Size = new System.Drawing.Size(55, 17);
            this.rBtnStatusActive.TabIndex = 65;
            this.rBtnStatusActive.TabStop = true;
            this.rBtnStatusActive.Text = "Active";
            this.rBtnStatusActive.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label10.Location = new System.Drawing.Point(26, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Status";
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(96, 195);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(65, 13);
            this.lblErrorName.TabIndex = 64;
            this.lblErrorName.Text = "*Enter name";
            this.lblErrorName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(99, 172);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 62;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label52.Location = new System.Drawing.Point(26, 172);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(49, 16);
            this.label52.TabIndex = 63;
            this.label52.Text = "Name";
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
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStatus.Location = new System.Drawing.Point(140, 236);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(72, 13);
            this.lblErrorStatus.TabIndex = 68;
            this.lblErrorStatus.Text = "*Select status";
            this.lblErrorStatus.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(306, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(193, 170);
            this.dataGridView1.TabIndex = 61;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(163)))), ((int)(((byte)(30)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(306, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblTitleSelected
            // 
            this.lblTitleSelected.AutoSize = true;
            this.lblTitleSelected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleSelected.Location = new System.Drawing.Point(60, 131);
            this.lblTitleSelected.Name = "lblTitleSelected";
            this.lblTitleSelected.Size = new System.Drawing.Size(55, 13);
            this.lblTitleSelected.TabIndex = 59;
            this.lblTitleSelected.Text = "Selected :";
            // 
            // lblSelectedFullname
            // 
            this.lblSelectedFullname.AutoSize = true;
            this.lblSelectedFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedFullname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectedFullname.Location = new System.Drawing.Point(115, 131);
            this.lblSelectedFullname.Name = "lblSelectedFullname";
            this.lblSelectedFullname.Size = new System.Drawing.Size(109, 13);
            this.lblSelectedFullname.TabIndex = 60;
            this.lblSelectedFullname.Text = "Pashazade Pervin";
            // 
            // iconBackspace
            // 
            this.iconBackspace.Image = ((System.Drawing.Image)(resources.GetObject("iconBackspace.Image")));
            this.iconBackspace.Location = new System.Drawing.Point(450, 42);
            this.iconBackspace.Name = "iconBackspace";
            this.iconBackspace.Size = new System.Drawing.Size(20, 20);
            this.iconBackspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBackspace.TabIndex = 47;
            this.iconBackspace.TabStop = false;
            this.iconBackspace.Click += new System.EventHandler(this.IconBackspace_Click);
            // 
            // iconSearch
            // 
            this.iconSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSearch.Image = ((System.Drawing.Image)(resources.GetObject("iconSearch.Image")));
            this.iconSearch.Location = new System.Drawing.Point(478, 42);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(21, 21);
            this.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSearch.TabIndex = 43;
            this.iconSearch.TabStop = false;
            this.iconSearch.Click += new System.EventHandler(this.IconSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(306, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Languages";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.pnlHeader.Controls.Add(this.iconBackspace);
            this.pnlHeader.Controls.Add(this.iconSearch);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(529, 100);
            this.pnlHeader.TabIndex = 56;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(388, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // AddLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(529, 361);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rBtnStatusDisabled);
            this.Controls.Add(this.rBtnStatusActive);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.lblErrorStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTitleSelected);
            this.Controls.Add(this.lblSelectedFullname);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnDelete);
            this.Name = "AddLanguageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library App - Languages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBackspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rBtnStatusDisabled;
        private System.Windows.Forms.RadioButton rBtnStatusActive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblErrorStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitleSelected;
        private System.Windows.Forms.Label lblSelectedFullname;
        private System.Windows.Forms.PictureBox iconBackspace;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnDelete;
    }
}