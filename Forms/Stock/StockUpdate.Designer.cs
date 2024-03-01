namespace NEA1.Forms.Stock
{
    partial class StockUpdate
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
            StockNumUpDown = new System.Windows.Forms.NumericUpDown();
            MaxStockNumUpDown = new System.Windows.Forms.NumericUpDown();
            CancelBtn = new System.Windows.Forms.Button();
            UpdateBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)StockNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxStockNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // StockNumUpDown
            // 
            StockNumUpDown.Location = new System.Drawing.Point(83, 7);
            StockNumUpDown.Maximum = new decimal(new int[] { -1304428545, 434162106, 542, 0 });
            StockNumUpDown.Name = "StockNumUpDown";
            StockNumUpDown.Size = new System.Drawing.Size(122, 23);
            StockNumUpDown.TabIndex = 1;
            // 
            // MaxStockNumUpDown
            // 
            MaxStockNumUpDown.Location = new System.Drawing.Point(83, 46);
            MaxStockNumUpDown.Maximum = new decimal(new int[] { 1241513983, 370409800, 542101, 0 });
            MaxStockNumUpDown.Name = "MaxStockNumUpDown";
            MaxStockNumUpDown.Size = new System.Drawing.Size(122, 23);
            MaxStockNumUpDown.TabIndex = 2;
            // 
            // CancelBtn
            // 
            CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            CancelBtn.Location = new System.Drawing.Point(69, 88);
            CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(64, 27);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new System.Drawing.Point(141, 88);
            UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new System.Drawing.Size(64, 27);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "Max Stock:";
            // 
            // StockUpdate
            // 
            AcceptButton = UpdateBtn;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new System.Drawing.Size(218, 128);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CancelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(MaxStockNumUpDown);
            Controls.Add(StockNumUpDown);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StockUpdate";
            ShowIcon = false;
            Text = "StockUpdate";
            ((System.ComponentModel.ISupportInitialize)StockNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxStockNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.NumericUpDown StockNumUpDown;
        private System.Windows.Forms.NumericUpDown MaxStockNumUpDown;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}