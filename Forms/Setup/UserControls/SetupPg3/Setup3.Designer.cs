namespace NEA1.Forms.Setup.UserControls.SetupPg3
{
    partial class Setup3
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
            ProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            ProductsLbl = new System.Windows.Forms.Label();
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
            backBtn.TabIndex = 9;
            backBtn.Text = "back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            nextBtn.Location = new System.Drawing.Point(532, 332);
            nextBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new System.Drawing.Size(88, 27);
            nextBtn.TabIndex = 8;
            nextBtn.Text = "next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // ProductsFlowPanel
            // 
            ProductsFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ProductsFlowPanel.AutoScroll = true;
            ProductsFlowPanel.Location = new System.Drawing.Point(13, 44);
            ProductsFlowPanel.Name = "ProductsFlowPanel";
            ProductsFlowPanel.Size = new System.Drawing.Size(607, 282);
            ProductsFlowPanel.TabIndex = 10;
            ProductsFlowPanel.Paint += flowLayoutPanel1_Paint;
            // 
            // ProductsLbl
            // 
            ProductsLbl.AutoSize = true;
            ProductsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            ProductsLbl.Location = new System.Drawing.Point(13, 20);
            ProductsLbl.Name = "ProductsLbl";
            ProductsLbl.Size = new System.Drawing.Size(181, 21);
            ProductsLbl.TabIndex = 11;
            ProductsLbl.Text = "Setup -  Create Products:";
            // 
            // AddBtn
            // 
            AddBtn.Location = new System.Drawing.Point(13, 332);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(75, 23);
            AddBtn.TabIndex = 16;
            AddBtn.Text = "Add New";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Setup3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(AddBtn);
            Controls.Add(ProductsLbl);
            Controls.Add(ProductsFlowPanel);
            Controls.Add(backBtn);
            Controls.Add(nextBtn);
            MaximumSize = new System.Drawing.Size(635, 375);
            MinimumSize = new System.Drawing.Size(635, 375);
            Name = "Setup3";
            Size = new System.Drawing.Size(635, 375);
            Load += Setup3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowPanel;
        private System.Windows.Forms.Label ProductsLbl;
        private System.Windows.Forms.Button AddBtn;
    }
}
