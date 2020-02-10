namespace LibraryFinalTask.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.pnlPassLogin = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.pnlEmailLogin = new System.Windows.Forms.Panel();
            this.btnLoginLoginF = new System.Windows.Forms.Button();
            this.iconExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(35, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassLogin.HideSelection = false;
            this.txtPassLogin.Location = new System.Drawing.Point(70, 258);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.Size = new System.Drawing.Size(223, 19);
            this.txtPassLogin.TabIndex = 1;
            this.txtPassLogin.TabStop = false;
            this.txtPassLogin.Text = "Password";
            this.txtPassLogin.Click += new System.EventHandler(this.TxtPassLogin_Click);
            // 
            // pnlPassLogin
            // 
            this.pnlPassLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPassLogin.Location = new System.Drawing.Point(35, 283);
            this.pnlPassLogin.Name = "pnlPassLogin";
            this.pnlPassLogin.Size = new System.Drawing.Size(258, 1);
            this.pnlPassLogin.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(35, 196);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmailLogin.HideSelection = false;
            this.txtEmailLogin.Location = new System.Drawing.Point(70, 198);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(223, 19);
            this.txtEmailLogin.TabIndex = 1;
            this.txtEmailLogin.TabStop = false;
            this.txtEmailLogin.Text = "Email";
            this.txtEmailLogin.Click += new System.EventHandler(this.TxtEmailLogin_Click);
            // 
            // pnlEmailLogin
            // 
            this.pnlEmailLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEmailLogin.Location = new System.Drawing.Point(35, 224);
            this.pnlEmailLogin.Name = "pnlEmailLogin";
            this.pnlEmailLogin.Size = new System.Drawing.Size(258, 1);
            this.pnlEmailLogin.TabIndex = 2;
            // 
            // btnLoginLoginF
            // 
            this.btnLoginLoginF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLoginLoginF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginLoginF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginLoginF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginLoginF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnLoginLoginF.Location = new System.Drawing.Point(35, 350);
            this.btnLoginLoginF.Name = "btnLoginLoginF";
            this.btnLoginLoginF.Size = new System.Drawing.Size(258, 37);
            this.btnLoginLoginF.TabIndex = 3;
            this.btnLoginLoginF.Text = "Login";
            this.btnLoginLoginF.UseVisualStyleBackColor = false;
            this.btnLoginLoginF.Click += new System.EventHandler(this.BtnLoginLoginF_Click);
            // 
            // iconExit
            // 
            this.iconExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconExit.Image = ((System.Drawing.Image)(resources.GetObject("iconExit.Image")));
            this.iconExit.Location = new System.Drawing.Point(305, 13);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(20, 20);
            this.iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExit.TabIndex = 4;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.IconExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(85, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Library App";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(62, 179);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(75, 13);
            this.lblErrorEmail.TabIndex = 18;
            this.lblErrorEmail.Text = "*Enter email";
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPass.Location = new System.Drawing.Point(62, 239);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(99, 13);
            this.lblErrorPass.TabIndex = 18;
            this.lblErrorPass.Text = "*Enter password";
            this.lblErrorPass.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.linkLabel1.Location = new System.Drawing.Point(145, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Pervin Pashazade";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(332, 465);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconExit);
            this.Controls.Add(this.btnLoginLoginF);
            this.Controls.Add(this.pnlEmailLogin);
            this.Controls.Add(this.pnlPassLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtPassLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Library App";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPassLogin;
        private System.Windows.Forms.Panel pnlPassLogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Panel pnlEmailLogin;
        private System.Windows.Forms.Button btnLoginLoginF;
        private System.Windows.Forms.PictureBox iconExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}