namespace NEA1.Forms.Setup.UserControls.SetupPg2;

partial class Setup2
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
        backBtn = new System.Windows.Forms.Button();
        nextBtn = new System.Windows.Forms.Button();
        UsersListBox = new System.Windows.Forms.ListBox();
        UsersLbl = new System.Windows.Forms.Label();
        RemoveBtn = new System.Windows.Forms.Button();
        ModifyBtn = new System.Windows.Forms.Button();
        AddBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // backBtn
        // 
        backBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        backBtn.Enabled = false;
        backBtn.Location = new System.Drawing.Point(436, 332);
        backBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        backBtn.Name = "backBtn";
        backBtn.Size = new System.Drawing.Size(88, 27);
        backBtn.TabIndex = 7;
        backBtn.Text = "back";
        backBtn.UseVisualStyleBackColor = true;
        // 
        // nextBtn
        // 
        nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        nextBtn.Location = new System.Drawing.Point(532, 332);
        nextBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        nextBtn.Name = "nextBtn";
        nextBtn.Size = new System.Drawing.Size(88, 27);
        nextBtn.TabIndex = 6;
        nextBtn.Text = "next";
        nextBtn.UseVisualStyleBackColor = true;
        nextBtn.Click += NextBtn;
        // 
        // UsersListBox
        // 
        UsersListBox.FormattingEnabled = true;
        UsersListBox.ItemHeight = 15;
        UsersListBox.Location = new System.Drawing.Point(15, 44);
        UsersListBox.Name = "UsersListBox";
        UsersListBox.Size = new System.Drawing.Size(607, 244);
        UsersListBox.TabIndex = 9;
        UsersListBox.SelectedIndexChanged += UsersListBox_SelectedIndexChanged;
        // 
        // UsersLbl
        // 
        UsersLbl.AutoSize = true;
        UsersLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
        UsersLbl.Location = new System.Drawing.Point(13, 20);
        UsersLbl.Name = "UsersLbl";
        UsersLbl.Size = new System.Drawing.Size(159, 21);
        UsersLbl.TabIndex = 10;
        UsersLbl.Text = "Setup -  Create Users:";
        // 
        // RemoveBtn
        // 
        RemoveBtn.Location = new System.Drawing.Point(15, 292);
        RemoveBtn.Name = "RemoveBtn";
        RemoveBtn.Size = new System.Drawing.Size(75, 23);
        RemoveBtn.TabIndex = 11;
        RemoveBtn.Text = "Remove";
        RemoveBtn.UseVisualStyleBackColor = true;
        RemoveBtn.Click += RemoveBtn_Click;
        // 
        // ModifyBtn
        // 
        ModifyBtn.Location = new System.Drawing.Point(96, 292);
        ModifyBtn.Name = "ModifyBtn";
        ModifyBtn.Size = new System.Drawing.Size(75, 23);
        ModifyBtn.TabIndex = 12;
        ModifyBtn.Text = "Modify";
        ModifyBtn.UseVisualStyleBackColor = true;
        ModifyBtn.Click += ModifyBtn_Click;
        // 
        // AddBtn
        // 
        AddBtn.Location = new System.Drawing.Point(545, 294);
        AddBtn.Name = "AddBtn";
        AddBtn.Size = new System.Drawing.Size(75, 23);
        AddBtn.TabIndex = 13;
        AddBtn.Text = "Add New";
        AddBtn.UseVisualStyleBackColor = true;
        AddBtn.Click += AddBtn_Click;
        // 
        // Setup2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(UsersListBox);
        Controls.Add(AddBtn);
        Controls.Add(ModifyBtn);
        Controls.Add(RemoveBtn);
        Controls.Add(UsersLbl);
        Controls.Add(backBtn);
        Controls.Add(nextBtn);
        Name = "Setup2";
        Size = new System.Drawing.Size(635, 375);
        Load += Setup2_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button backBtn;
    private System.Windows.Forms.Button nextBtn;
    private System.Windows.Forms.ListBox UsersListBox;
    private System.Windows.Forms.Label UsersLbl;
    private System.Windows.Forms.Button RemoveBtn;
    private System.Windows.Forms.Button ModifyBtn;
    private System.Windows.Forms.Button AddBtn;
}
