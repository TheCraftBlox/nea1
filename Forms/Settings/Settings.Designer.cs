namespace NEA1.Forms.Settings
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PasswordTxtBox = new System.Windows.Forms.TextBox();
            PasswordTxtBox2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            UpdatePasswordBtn = new System.Windows.Forms.Button();
            UsersListBox = new System.Windows.Forms.ListBox();
            RemoveBtn = new System.Windows.Forms.Button();
            ModifyBtn = new System.Windows.Forms.Button();
            AddBtn = new System.Windows.Forms.Button();
            AdminPanel = new System.Windows.Forms.Panel();
            PasswordUpdateErrorLbl = new System.Windows.Forms.Label();
            AdminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new System.Drawing.Point(17, 20);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new System.Drawing.Size(170, 23);
            PasswordTxtBox.TabIndex = 0;
            PasswordTxtBox.UseSystemPasswordChar = true;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            PasswordTxtBox.Enter += PasswordTxtBox_Enter;
            // 
            // PasswordTxtBox2
            // 
            PasswordTxtBox2.Location = new System.Drawing.Point(17, 67);
            PasswordTxtBox2.Name = "PasswordTxtBox2";
            PasswordTxtBox2.Size = new System.Drawing.Size(170, 23);
            PasswordTxtBox2.TabIndex = 1;
            PasswordTxtBox2.UseSystemPasswordChar = true;
            PasswordTxtBox2.TextChanged += PasswordTxtBox2_TextChanged;
            PasswordTxtBox2.Enter += PasswordTxtBox2_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Retype Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 2);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // UpdatePasswordBtn
            // 
            UpdatePasswordBtn.Location = new System.Drawing.Point(17, 96);
            UpdatePasswordBtn.Name = "UpdatePasswordBtn";
            UpdatePasswordBtn.Size = new System.Drawing.Size(170, 26);
            UpdatePasswordBtn.TabIndex = 4;
            UpdatePasswordBtn.Text = "Update Password";
            UpdatePasswordBtn.UseVisualStyleBackColor = true;
            UpdatePasswordBtn.Click += UpdatePasswordBtn_Click;
            // 
            // UsersListBox
            // 
            UsersListBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new System.Drawing.Point(0, 0);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new System.Drawing.Size(435, 334);
            UsersListBox.TabIndex = 5;
            UsersListBox.SelectedIndexChanged += UsersListBox_SelectedIndexChanged;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            RemoveBtn.Location = new System.Drawing.Point(3, 349);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new System.Drawing.Size(87, 23);
            RemoveBtn.TabIndex = 6;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // ModifyBtn
            // 
            ModifyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ModifyBtn.Location = new System.Drawing.Point(96, 349);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new System.Drawing.Size(87, 23);
            ModifyBtn.TabIndex = 7;
            ModifyBtn.Text = "Modify";
            ModifyBtn.UseVisualStyleBackColor = true;
            ModifyBtn.Click += ModiftBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            AddBtn.Location = new System.Drawing.Point(345, 349);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(87, 23);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add New";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(UsersListBox);
            AdminPanel.Controls.Add(RemoveBtn);
            AdminPanel.Controls.Add(ModifyBtn);
            AdminPanel.Controls.Add(AddBtn);
            AdminPanel.Dock = System.Windows.Forms.DockStyle.Right;
            AdminPanel.Enabled = false;
            AdminPanel.Location = new System.Drawing.Point(200, 0);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new System.Drawing.Size(435, 375);
            AdminPanel.TabIndex = 9;
            AdminPanel.Visible = false;
            // 
            // PasswordUpdateErrorLbl
            // 
            PasswordUpdateErrorLbl.AutoSize = true;
            PasswordUpdateErrorLbl.ForeColor = System.Drawing.Color.Red;
            PasswordUpdateErrorLbl.Location = new System.Drawing.Point(17, 125);
            PasswordUpdateErrorLbl.Name = "PasswordUpdateErrorLbl";
            PasswordUpdateErrorLbl.Size = new System.Drawing.Size(0, 15);
            PasswordUpdateErrorLbl.TabIndex = 10;
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(PasswordUpdateErrorLbl);
            Controls.Add(AdminPanel);
            Controls.Add(UpdatePasswordBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxtBox2);
            Controls.Add(PasswordTxtBox);
            Name = "Settings";
            Size = new System.Drawing.Size(635, 375);
            Load += Settings_Load;
            AdminPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdatePasswordBtn;
        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Label PasswordUpdateErrorLbl;
    }
}
