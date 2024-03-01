namespace NEA1.Forms.Setup.UserControls.Setup2
{
    partial class AddUser
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
            UserNameLbl = new System.Windows.Forms.Label();
            ConfirmBtn = new System.Windows.Forms.Button();
            CancelBtn = new System.Windows.Forms.Button();
            UsernameTxtBox = new System.Windows.Forms.TextBox();
            PasswordTxtBox = new System.Windows.Forms.TextBox();
            PasswordTxtBox2 = new System.Windows.Forms.TextBox();
            PasswordLbl = new System.Windows.Forms.Label();
            RetypePasswordLbl = new System.Windows.Forms.Label();
            PageListBox = new System.Windows.Forms.CheckedListBox();
            AddErrorBoxLbl = new System.Windows.Forms.Label();
            adminCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Location = new System.Drawing.Point(12, 23);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new System.Drawing.Size(63, 15);
            UserNameLbl.TabIndex = 0;
            UserNameLbl.Text = "Username:";
            UserNameLbl.Click += label1_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Enabled = false;
            ConfirmBtn.Location = new System.Drawing.Point(242, 364);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            ConfirmBtn.TabIndex = 1;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new System.Drawing.Point(161, 364);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(75, 23);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Location = new System.Drawing.Point(81, 20);
            UsernameTxtBox.MaxLength = 32;
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new System.Drawing.Size(236, 23);
            UsernameTxtBox.TabIndex = 3;
            UsernameTxtBox.TextChanged += UsernameTxtBox_TextChanged;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new System.Drawing.Point(117, 74);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new System.Drawing.Size(200, 23);
            PasswordTxtBox.TabIndex = 4;
            PasswordTxtBox.UseSystemPasswordChar = true;
            PasswordTxtBox.Enter += PasswordTxtBox_Enter;
            // 
            // PasswordTxtBox2
            // 
            PasswordTxtBox2.Location = new System.Drawing.Point(117, 103);
            PasswordTxtBox2.Name = "PasswordTxtBox2";
            PasswordTxtBox2.Size = new System.Drawing.Size(200, 23);
            PasswordTxtBox2.TabIndex = 5;
            PasswordTxtBox2.UseSystemPasswordChar = true;
            PasswordTxtBox2.TextChanged += PasswordTxtBox2_TextChanged;
            PasswordTxtBox2.Enter += PasswordTxtBox2_Enter;
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new System.Drawing.Point(15, 82);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new System.Drawing.Size(60, 15);
            PasswordLbl.TabIndex = 6;
            PasswordLbl.Text = "Password:";
            // 
            // RetypePasswordLbl
            // 
            RetypePasswordLbl.AutoSize = true;
            RetypePasswordLbl.Location = new System.Drawing.Point(12, 111);
            RetypePasswordLbl.Name = "RetypePasswordLbl";
            RetypePasswordLbl.Size = new System.Drawing.Size(99, 15);
            RetypePasswordLbl.TabIndex = 7;
            RetypePasswordLbl.Text = "Retype Password:";
            // 
            // PageListBox
            // 
            PageListBox.FormattingEnabled = true;
            PageListBox.Location = new System.Drawing.Point(12, 168);
            PageListBox.Name = "PageListBox";
            PageListBox.Size = new System.Drawing.Size(305, 166);
            PageListBox.TabIndex = 8;
            PageListBox.SelectedIndexChanged += PageListBox_SelectedIndexChanged;
            // 
            // AddErrorBoxLbl
            // 
            AddErrorBoxLbl.AutoSize = true;
            AddErrorBoxLbl.ForeColor = System.Drawing.Color.Red;
            AddErrorBoxLbl.Location = new System.Drawing.Point(117, 129);
            AddErrorBoxLbl.Name = "AddErrorBoxLbl";
            AddErrorBoxLbl.Size = new System.Drawing.Size(0, 15);
            AddErrorBoxLbl.TabIndex = 9;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Location = new System.Drawing.Point(12, 340);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new System.Drawing.Size(110, 19);
            adminCheckBox.TabIndex = 10;
            adminCheckBox.Text = "Admin Account";
            adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            AcceptButton = ConfirmBtn;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new System.Drawing.Size(329, 399);
            Controls.Add(adminCheckBox);
            Controls.Add(AddErrorBoxLbl);
            Controls.Add(PageListBox);
            Controls.Add(RetypePasswordLbl);
            Controls.Add(PasswordLbl);
            Controls.Add(PasswordTxtBox2);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UsernameTxtBox);
            Controls.Add(CancelBtn);
            Controls.Add(ConfirmBtn);
            Controls.Add(UserNameLbl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected System.Windows.Forms.Label UserNameLbl;
        protected System.Windows.Forms.Button ConfirmBtn;
        protected System.Windows.Forms.Button CancelBtn;
        protected System.Windows.Forms.TextBox UsernameTxtBox;
        protected System.Windows.Forms.TextBox PasswordTxtBox;
        protected System.Windows.Forms.TextBox PasswordTxtBox2;
        protected System.Windows.Forms.Label PasswordLbl;
        protected System.Windows.Forms.Label RetypePasswordLbl;
        protected System.Windows.Forms.CheckedListBox PageListBox;
        protected System.Windows.Forms.Label AddErrorBoxLbl;
        protected System.Windows.Forms.CheckBox adminCheckBox;
    }
}