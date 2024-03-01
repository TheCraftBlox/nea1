namespace NEA1.Forms.Login
{
    partial class Login
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
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PaswordBtn = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.LoginSuccessLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxtbox.Location = new System.Drawing.Point(76, 13);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTxtbox.TabIndex = 0;
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Location = new System.Drawing.Point(76, 46);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxtbox.TabIndex = 1;
            this.PasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(10, 16);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(58, 13);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username:";
            // 
            // PaswordBtn
            // 
            this.PaswordBtn.AutoSize = true;
            this.PaswordBtn.Location = new System.Drawing.Point(12, 49);
            this.PaswordBtn.Name = "PaswordBtn";
            this.PaswordBtn.Size = new System.Drawing.Size(56, 13);
            this.PaswordBtn.TabIndex = 3;
            this.PaswordBtn.Text = "Password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(122, 98);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(55, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(60, 98);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(55, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LoginSuccessLbl
            // 
            this.LoginSuccessLbl.AutoSize = true;
            this.LoginSuccessLbl.Location = new System.Drawing.Point(13, 75);
            this.LoginSuccessLbl.Name = "LoginSuccessLbl";
            this.LoginSuccessLbl.Size = new System.Drawing.Size(0, 13);
            this.LoginSuccessLbl.TabIndex = 6;
            // 
            // Login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(189, 133);
            this.Controls.Add(this.LoginSuccessLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PaswordBtn);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.UsernameTxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(205, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(205, 172);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PaswordBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label LoginSuccessLbl;
    }
}