namespace LibraryFinalTask.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnLoginRegF = new System.Windows.Forms.Button();
            this.btnRegisterRegF = new System.Windows.Forms.Button();
            this.pnlEmailReg = new System.Windows.Forms.Panel();
            this.pnlPassReg = new System.Windows.Forms.Panel();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSurnameReg = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtNameReg = new System.Windows.Forms.TextBox();
            this.pnlSurnameReg = new System.Windows.Forms.Panel();
            this.pnlNameReg = new System.Windows.Forms.Panel();
            this.checkboxTermsReg = new System.Windows.Forms.CheckBox();
            this.lblTermsLink = new System.Windows.Forms.Label();
            this.iconExit = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorSurname = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginRegF
            // 
            this.btnLoginRegF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnLoginRegF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginRegF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRegF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginRegF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLoginRegF.Location = new System.Drawing.Point(37, 498);
            this.btnLoginRegF.Name = "btnLoginRegF";
            this.btnLoginRegF.Size = new System.Drawing.Size(258, 37);
            this.btnLoginRegF.TabIndex = 11;
            this.btnLoginRegF.TabStop = false;
            this.btnLoginRegF.Text = "Login";
            this.btnLoginRegF.UseVisualStyleBackColor = false;
            this.btnLoginRegF.Click += new System.EventHandler(this.BtnLoginRegF_Click);
            // 
            // btnRegisterRegF
            // 
            this.btnRegisterRegF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRegisterRegF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterRegF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterRegF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterRegF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnRegisterRegF.Location = new System.Drawing.Point(37, 446);
            this.btnRegisterRegF.Name = "btnRegisterRegF";
            this.btnRegisterRegF.Size = new System.Drawing.Size(258, 37);
            this.btnRegisterRegF.TabIndex = 12;
            this.btnRegisterRegF.TabStop = false;
            this.btnRegisterRegF.Text = "Create Account";
            this.btnRegisterRegF.UseVisualStyleBackColor = false;
            this.btnRegisterRegF.Click += new System.EventHandler(this.BtnRegisterRegF_Click);
            // 
            // pnlEmailReg
            // 
            this.pnlEmailReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEmailReg.Location = new System.Drawing.Point(37, 308);
            this.pnlEmailReg.Name = "pnlEmailReg";
            this.pnlEmailReg.Size = new System.Drawing.Size(258, 1);
            this.pnlEmailReg.TabIndex = 9;
            // 
            // pnlPassReg
            // 
            this.pnlPassReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPassReg.Location = new System.Drawing.Point(37, 357);
            this.pnlPassReg.Name = "pnlPassReg";
            this.pnlPassReg.Size = new System.Drawing.Size(258, 1);
            this.pnlPassReg.TabIndex = 10;
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtEmailReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailReg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmailReg.HideSelection = false;
            this.txtEmailReg.Location = new System.Drawing.Point(72, 282);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(223, 19);
            this.txtEmailReg.TabIndex = 7;
            this.txtEmailReg.TabStop = false;
            this.txtEmailReg.Text = "Email";
            this.txtEmailReg.Click += new System.EventHandler(this.TxtEmailReg_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(37, 279);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // txtPassReg
            // 
            this.txtPassReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtPassReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassReg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassReg.HideSelection = false;
            this.txtPassReg.Location = new System.Drawing.Point(72, 332);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.Size = new System.Drawing.Size(223, 19);
            this.txtPassReg.TabIndex = 8;
            this.txtPassReg.TabStop = false;
            this.txtPassReg.Text = "Password";
            this.txtPassReg.Click += new System.EventHandler(this.TxtPassReg_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtSurnameReg
            // 
            this.txtSurnameReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtSurnameReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurnameReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurnameReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurnameReg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSurnameReg.HideSelection = false;
            this.txtSurnameReg.Location = new System.Drawing.Point(72, 236);
            this.txtSurnameReg.Name = "txtSurnameReg";
            this.txtSurnameReg.Size = new System.Drawing.Size(223, 19);
            this.txtSurnameReg.TabIndex = 8;
            this.txtSurnameReg.TabStop = false;
            this.txtSurnameReg.Text = "Surname";
            this.txtSurnameReg.Click += new System.EventHandler(this.TxtSurnameReg_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(37, 183);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // txtNameReg
            // 
            this.txtNameReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtNameReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameReg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNameReg.HideSelection = false;
            this.txtNameReg.Location = new System.Drawing.Point(72, 187);
            this.txtNameReg.Name = "txtNameReg";
            this.txtNameReg.Size = new System.Drawing.Size(223, 19);
            this.txtNameReg.TabIndex = 7;
            this.txtNameReg.TabStop = false;
            this.txtNameReg.Text = "Name";
            this.txtNameReg.Click += new System.EventHandler(this.TxtNameReg_Click);
            // 
            // pnlSurnameReg
            // 
            this.pnlSurnameReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSurnameReg.Location = new System.Drawing.Point(37, 261);
            this.pnlSurnameReg.Name = "pnlSurnameReg";
            this.pnlSurnameReg.Size = new System.Drawing.Size(258, 1);
            this.pnlSurnameReg.TabIndex = 10;
            // 
            // pnlNameReg
            // 
            this.pnlNameReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNameReg.Location = new System.Drawing.Point(37, 213);
            this.pnlNameReg.Name = "pnlNameReg";
            this.pnlNameReg.Size = new System.Drawing.Size(258, 1);
            this.pnlNameReg.TabIndex = 9;
            // 
            // checkboxTermsReg
            // 
            this.checkboxTermsReg.AutoSize = true;
            this.checkboxTermsReg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkboxTermsReg.Location = new System.Drawing.Point(37, 403);
            this.checkboxTermsReg.Name = "checkboxTermsReg";
            this.checkboxTermsReg.Size = new System.Drawing.Size(127, 17);
            this.checkboxTermsReg.TabIndex = 13;
            this.checkboxTermsReg.TabStop = false;
            this.checkboxTermsReg.Text = "I agree to Library App";
            this.checkboxTermsReg.UseVisualStyleBackColor = true;
            // 
            // lblTermsLink
            // 
            this.lblTermsLink.AutoSize = true;
            this.lblTermsLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTermsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTermsLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTermsLink.Location = new System.Drawing.Point(159, 405);
            this.lblTermsLink.Name = "lblTermsLink";
            this.lblTermsLink.Size = new System.Drawing.Size(124, 13);
            this.lblTermsLink.TabIndex = 14;
            this.lblTermsLink.Text = "terms and conditions";
            this.lblTermsLink.Click += new System.EventHandler(this.LblTermsLink_Click);
            // 
            // iconExit
            // 
            this.iconExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconExit.Image = ((System.Drawing.Image)(resources.GetObject("iconExit.Image")));
            this.iconExit.Location = new System.Drawing.Point(305, 13);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(20, 20);
            this.iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExit.TabIndex = 0;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.IconExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            // 
            // lblErrorName
            // 
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(64, 170);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(115, 17);
            this.lblErrorName.TabIndex = 0;
            this.lblErrorName.Text = "*Enter name";
            this.lblErrorName.Visible = false;
            // 
            // lblErrorSurname
            // 
            this.lblErrorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorSurname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSurname.Location = new System.Drawing.Point(64, 220);
            this.lblErrorSurname.Name = "lblErrorSurname";
            this.lblErrorSurname.Size = new System.Drawing.Size(115, 16);
            this.lblErrorSurname.TabIndex = 0;
            this.lblErrorSurname.Text = "*Enter surname";
            this.lblErrorSurname.Visible = false;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(64, 267);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(115, 16);
            this.lblErrorEmail.TabIndex = 0;
            this.lblErrorEmail.Text = "*Enter email";
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPass.Location = new System.Drawing.Point(64, 314);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(115, 16);
            this.lblErrorPass.TabIndex = 0;
            this.lblErrorPass.Text = "*Enter password";
            this.lblErrorPass.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(332, 570);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorSurname);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.iconExit);
            this.Controls.Add(this.lblTermsLink);
            this.Controls.Add(this.checkboxTermsReg);
            this.Controls.Add(this.btnLoginRegF);
            this.Controls.Add(this.btnRegisterRegF);
            this.Controls.Add(this.pnlNameReg);
            this.Controls.Add(this.pnlEmailReg);
            this.Controls.Add(this.pnlSurnameReg);
            this.Controls.Add(this.pnlPassReg);
            this.Controls.Add(this.txtNameReg);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtEmailReg);
            this.Controls.Add(this.txtSurnameReg);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPassReg);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginRegF;
        private System.Windows.Forms.Button btnRegisterRegF;
        private System.Windows.Forms.Panel pnlEmailReg;
        private System.Windows.Forms.Panel pnlPassReg;
        private System.Windows.Forms.TextBox txtEmailReg;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSurnameReg;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtNameReg;
        private System.Windows.Forms.Panel pnlSurnameReg;
        private System.Windows.Forms.Panel pnlNameReg;
        private System.Windows.Forms.CheckBox checkboxTermsReg;
        private System.Windows.Forms.Label lblTermsLink;
        private System.Windows.Forms.PictureBox iconExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorSurname;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPass;
    }
}