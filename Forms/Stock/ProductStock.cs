using NEA1.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA1.Forms.Stock
{
    internal class ProductStock : Product
    {
        public ProductStock(int ProductID) : base(ProductID)
        {
            InitializeComponent();
            StockLbl.Text = stock.ToString();
            MaxStockLbl.Text = maxStock.ToString();
            StockPercentLbl.Text = (100 * Stock / MaxStock).ToString("0") + "%";
            stockBar.Percentage = (100 * Stock / MaxStock);
        }

        private void InitializeComponent()
        {
            SettingsBtn = new Button();
            stockBar = new StockBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            StockPercentLbl = new Label();
            StockLbl = new Label();
            MaxStockLbl = new Label();
            SuspendLayout();
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackgroundImage = Properties.Resources.settings;
            SettingsBtn.BackgroundImageLayout = ImageLayout.Zoom;
            SettingsBtn.Location = new System.Drawing.Point(256, 3);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new System.Drawing.Size(30, 30);
            SettingsBtn.TabIndex = 8;
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // stockBar
            // 
            stockBar.Location = new System.Drawing.Point(122, 37);
            stockBar.Name = "stockBar";
            stockBar.Percentage = 0;
            stockBar.Size = new System.Drawing.Size(32, 100);
            stockBar.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(160, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(160, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Stock %:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(160, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 15);
            label3.TabIndex = 12;
            label3.Text = "MaxStock:";
            // 
            // StockPercentLbl
            // 
            StockPercentLbl.AutoSize = true;
            StockPercentLbl.Location = new System.Drawing.Point(218, 122);
            StockPercentLbl.Name = "StockPercentLbl";
            StockPercentLbl.Size = new System.Drawing.Size(0, 15);
            StockPercentLbl.TabIndex = 13;
            // 
            // StockLbl
            // 
            StockLbl.AutoSize = true;
            StockLbl.Location = new System.Drawing.Point(205, 68);
            StockLbl.Name = "StockLbl";
            StockLbl.Size = new System.Drawing.Size(0, 15);
            StockLbl.TabIndex = 14;
            // 
            // MaxStockLbl
            // 
            MaxStockLbl.AutoSize = true;
            MaxStockLbl.Location = new System.Drawing.Point(228, 92);
            MaxStockLbl.Name = "MaxStockLbl";
            MaxStockLbl.Size = new System.Drawing.Size(0, 15);
            MaxStockLbl.TabIndex = 15;
            // 
            // ProductStock
            // 
            Controls.Add(MaxStockLbl);
            Controls.Add(StockLbl);
            Controls.Add(StockPercentLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stockBar);
            Controls.Add(SettingsBtn);
            Name = "ProductStock";
            Size = new System.Drawing.Size(289, 146);
            ResumeLayout(false);
            PerformLayout();
        }

        protected System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StockPercentLbl;
        private System.Windows.Forms.Label StockLbl;
        private System.Windows.Forms.Label MaxStockLbl;
        private StockBar stockBar;
        public event EventHandler Reload;
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            //create new stockupdate form
            StockUpdate stockUpdate = new StockUpdate(productID);

            //show form to user and get result
            DialogResult result = stockUpdate.ShowDialog();
            
            //if stock updated
            if (DialogResult.OK == result)
            {
                string sql = $"UPDATE Products SET ProductStock = {stockUpdate.Stock}, ProductMaxStock = {stockUpdate.MaxStock} WHERE ProductID = {productID};";

                //execute the sql
                DB db = new();
                db.ExecuteQuery(sql);

                //call toi reload the form with updated values
                Reload.Invoke(this, e);
            }
        }
    }
}
