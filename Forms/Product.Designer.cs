namespace NEA1.Forms
{
    partial class Product
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
            productImg = new System.Windows.Forms.PictureBox();
            NameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)productImg).BeginInit();
            SuspendLayout();
            // 
            // productImg
            // 
            productImg.Location = new System.Drawing.Point(12, 37);
            productImg.Name = "productImg";
            productImg.Size = new System.Drawing.Size(100, 100);
            productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            productImg.TabIndex = 1;
            productImg.TabStop = false;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            NameLbl.Location = new System.Drawing.Point(12, 13);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new System.Drawing.Size(120, 21);
            NameLbl.TabIndex = 2;
            NameLbl.Text = "Product Name";
            // 
            // Product
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(NameLbl);
            Controls.Add(productImg);
            Name = "Product";
            Size = new System.Drawing.Size(289, 146);
            ((System.ComponentModel.ISupportInitialize)productImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected System.Windows.Forms.PictureBox productImg;
        protected System.Windows.Forms.Label NameLbl;
    }
}
