namespace NEA1.Forms.CreateOrder
{
    partial class CreateOrder
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
            FinaliseBtn = new System.Windows.Forms.Button();
            ProductFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            PriceLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // FinaliseBtn
            // 
            FinaliseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            FinaliseBtn.Enabled = false;
            FinaliseBtn.Location = new System.Drawing.Point(880, 503);
            FinaliseBtn.Name = "FinaliseBtn";
            FinaliseBtn.Size = new System.Drawing.Size(205, 52);
            FinaliseBtn.TabIndex = 1;
            FinaliseBtn.Text = "Finalise";
            FinaliseBtn.UseVisualStyleBackColor = true;
            FinaliseBtn.Click += FinaliseBtn_Click;
            // 
            // ProductFlowPanel
            // 
            ProductFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ProductFlowPanel.AutoScroll = true;
            ProductFlowPanel.Location = new System.Drawing.Point(3, 3);
            ProductFlowPanel.Name = "ProductFlowPanel";
            ProductFlowPanel.Size = new System.Drawing.Size(1082, 459);
            ProductFlowPanel.TabIndex = 2;
            ProductFlowPanel.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            label1.Location = new System.Drawing.Point(3, 511);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 28);
            label1.TabIndex = 3;
            label1.Text = "Price:";
            // 
            // PriceLbl
            // 
            PriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            PriceLbl.AutoSize = true;
            PriceLbl.Font = new System.Drawing.Font("Segoe UI", 15F);
            PriceLbl.Location = new System.Drawing.Point(67, 511);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new System.Drawing.Size(23, 28);
            PriceLbl.TabIndex = 4;
            PriceLbl.Text = "£";
            PriceLbl.Click += label2_Click;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(PriceLbl);
            Controls.Add(label1);
            Controls.Add(ProductFlowPanel);
            Controls.Add(FinaliseBtn);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CreateOrder";
            Size = new System.Drawing.Size(1097, 567);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button FinaliseBtn;
        private System.Windows.Forms.FlowLayoutPanel ProductFlowPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLbl;
    }
}
