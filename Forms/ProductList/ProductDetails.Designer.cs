using System.Drawing;

namespace NEA1.Forms.ProductList
{
    partial class ProductDetails
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
            PriceTextLbl = new System.Windows.Forms.Label();
            DeleteBtn = new System.Windows.Forms.Button();
            StockTxtLbl = new System.Windows.Forms.Label();
            MaxStocktxtLbl = new System.Windows.Forms.Label();
            SettingsBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            PriceLbl = new System.Windows.Forms.Label();
            StockLbl = new System.Windows.Forms.Label();
            MaxStockLbl = new System.Windows.Forms.Label();
            StockPercentLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // PriceTextLbl
            // 
            PriceTextLbl.AutoSize = true;
            PriceTextLbl.Location = new Point(122, 47);
            PriceTextLbl.Name = "PriceTextLbl";
            PriceTextLbl.Size = new Size(36, 15);
            PriceTextLbl.TabIndex = 2;
            PriceTextLbl.Text = "Price:";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackgroundImage = Properties.Resources.delete;
            DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            DeleteBtn.Location = new Point(256, 3);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(30, 30);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // StockTxtLbl
            // 
            StockTxtLbl.AutoSize = true;
            StockTxtLbl.Location = new Point(122, 76);
            StockTxtLbl.Name = "StockTxtLbl";
            StockTxtLbl.Size = new Size(39, 15);
            StockTxtLbl.TabIndex = 5;
            StockTxtLbl.Text = "Stock:";
            // 
            // MaxStocktxtLbl
            // 
            MaxStocktxtLbl.AutoSize = true;
            MaxStocktxtLbl.Location = new Point(122, 99);
            MaxStocktxtLbl.Name = "MaxStocktxtLbl";
            MaxStocktxtLbl.Size = new Size(65, 15);
            MaxStocktxtLbl.TabIndex = 6;
            MaxStocktxtLbl.Text = "Max Stock:";
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackgroundImage = Properties.Resources.settings;
            SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            SettingsBtn.Location = new Point(220, 3);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(30, 30);
            SettingsBtn.TabIndex = 7;
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 122);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 8;
            label1.Text = "Stock % :";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(191, 47);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(0, 15);
            PriceLbl.TabIndex = 9;
            // 
            // StockLbl
            // 
            StockLbl.AutoSize = true;
            StockLbl.Location = new Point(191, 76);
            StockLbl.Name = "StockLbl";
            StockLbl.Size = new Size(0, 15);
            StockLbl.TabIndex = 10;
            // 
            // MaxStockLbl
            // 
            MaxStockLbl.AutoSize = true;
            MaxStockLbl.Location = new Point(191, 99);
            MaxStockLbl.Name = "MaxStockLbl";
            MaxStockLbl.Size = new Size(0, 15);
            MaxStockLbl.TabIndex = 11;
            // 
            // StockPercentLbl
            // 
            StockPercentLbl.AutoSize = true;
            StockPercentLbl.Location = new Point(191, 122);
            StockPercentLbl.Name = "StockPercentLbl";
            StockPercentLbl.Size = new Size(0, 15);
            StockPercentLbl.TabIndex = 12;
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(StockPercentLbl);
            Controls.Add(MaxStockLbl);
            Controls.Add(StockLbl);
            Controls.Add(PriceLbl);
            Controls.Add(label1);
            Controls.Add(SettingsBtn);
            Controls.Add(MaxStocktxtLbl);
            Controls.Add(StockTxtLbl);
            Controls.Add(DeleteBtn);
            Controls.Add(PriceTextLbl);
            Name = "ProductDetails";
            Size = new Size(289, 146);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected System.Windows.Forms.Label PriceTextLbl;
        protected System.Windows.Forms.Button DeleteBtn;
        protected System.Windows.Forms.Label StockTxtLbl;
        protected System.Windows.Forms.Label MaxStocktxtLbl;
        protected System.Windows.Forms.Button SettingsBtn;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label PriceLbl;
        protected System.Windows.Forms.Label StockLbl;
        protected System.Windows.Forms.Label MaxStockLbl;
        protected System.Windows.Forms.Label StockPercentLbl;
    }
}
