namespace NEA1.Forms.ProductList
{
    partial class AddProduct
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
            label1 = new System.Windows.Forms.Label();
            ProductNameTxtBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SelectImageBtn = new System.Windows.Forms.Button();
            SelectedImage = new System.Windows.Forms.PictureBox();
            priceNumUpDown = new System.Windows.Forms.NumericUpDown();
            stockNumUpDown = new System.Windows.Forms.NumericUpDown();
            maxStockNumUpDown = new System.Windows.Forms.NumericUpDown();
            ConfirmBtn = new System.Windows.Forms.Button();
            CancelBtn = new System.Windows.Forms.Button();
            SelectedImageLocationLbl = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)SelectedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxStockNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // ProductNameTxtBox
            // 
            ProductNameTxtBox.Location = new System.Drawing.Point(80, 14);
            ProductNameTxtBox.Name = "ProductNameTxtBox";
            ProductNameTxtBox.Size = new System.Drawing.Size(177, 23);
            ProductNameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Price: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 103);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 15);
            label4.TabIndex = 4;
            label4.Text = "Max Stock:";
            // 
            // SelectImageBtn
            // 
            SelectImageBtn.Location = new System.Drawing.Point(12, 130);
            SelectImageBtn.Name = "SelectImageBtn";
            SelectImageBtn.Size = new System.Drawing.Size(100, 23);
            SelectImageBtn.TabIndex = 6;
            SelectImageBtn.Text = "Select Image";
            SelectImageBtn.UseVisualStyleBackColor = true;
            SelectImageBtn.Click += SelectImageBtn_Click;
            // 
            // SelectedImage
            // 
            SelectedImage.Image = Properties.Resources._default;
            SelectedImage.InitialImage = Properties.Resources._default;
            SelectedImage.Location = new System.Drawing.Point(12, 156);
            SelectedImage.Name = "SelectedImage";
            SelectedImage.Size = new System.Drawing.Size(100, 100);
            SelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            SelectedImage.TabIndex = 7;
            SelectedImage.TabStop = false;
            // 
            // priceNumUpDown
            // 
            priceNumUpDown.DecimalPlaces = 2;
            priceNumUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            priceNumUpDown.Location = new System.Drawing.Point(80, 43);
            priceNumUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            priceNumUpDown.Name = "priceNumUpDown";
            priceNumUpDown.Size = new System.Drawing.Size(177, 23);
            priceNumUpDown.TabIndex = 8;
            // 
            // stockNumUpDown
            // 
            stockNumUpDown.Location = new System.Drawing.Point(80, 72);
            stockNumUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            stockNumUpDown.Name = "stockNumUpDown";
            stockNumUpDown.Size = new System.Drawing.Size(177, 23);
            stockNumUpDown.TabIndex = 9;
            // 
            // maxStockNumUpDown
            // 
            maxStockNumUpDown.Location = new System.Drawing.Point(80, 101);
            maxStockNumUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            maxStockNumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxStockNumUpDown.Name = "maxStockNumUpDown";
            maxStockNumUpDown.Size = new System.Drawing.Size(177, 23);
            maxStockNumUpDown.TabIndex = 10;
            maxStockNumUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new System.Drawing.Point(197, 260);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new System.Drawing.Size(60, 23);
            ConfirmBtn.TabIndex = 11;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new System.Drawing.Point(136, 260);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(55, 23);
            CancelBtn.TabIndex = 12;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += button3_Click;
            // 
            // SelectedImageLocationLbl
            // 
            SelectedImageLocationLbl.AutoSize = true;
            SelectedImageLocationLbl.Location = new System.Drawing.Point(118, 134);
            SelectedImageLocationLbl.MaximumSize = new System.Drawing.Size(130, 100);
            SelectedImageLocationLbl.Name = "SelectedImageLocationLbl";
            SelectedImageLocationLbl.Size = new System.Drawing.Size(122, 15);
            SelectedImageLocationLbl.TabIndex = 13;
            SelectedImageLocationLbl.Text = "DefaultImageSelected";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(65, 45);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(13, 15);
            label7.TabIndex = 14;
            label7.Text = "£";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddProduct
            // 
            AcceptButton = ConfirmBtn;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new System.Drawing.Size(269, 296);
            Controls.Add(label7);
            Controls.Add(SelectedImageLocationLbl);
            Controls.Add(CancelBtn);
            Controls.Add(ConfirmBtn);
            Controls.Add(maxStockNumUpDown);
            Controls.Add(stockNumUpDown);
            Controls.Add(priceNumUpDown);
            Controls.Add(SelectedImage);
            Controls.Add(SelectImageBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ProductNameTxtBox);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)SelectedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxStockNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button SelectImageBtn;
        protected System.Windows.Forms.PictureBox SelectedImage;
        protected System.Windows.Forms.NumericUpDown priceNumUpDown;
        protected System.Windows.Forms.NumericUpDown stockNumUpDown;
        protected System.Windows.Forms.NumericUpDown maxStockNumUpDown;
        protected System.Windows.Forms.Button CancelBtn;
        protected System.Windows.Forms.Button ConfirmBtn;
        protected System.Windows.Forms.Label SelectedImageLocationLbl;
        protected System.Windows.Forms.TextBox ProductNameTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}