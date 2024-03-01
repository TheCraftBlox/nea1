using System;

namespace NEA1.Forms.CreateOrder
{
    internal class ProductAddOrder : Product
    {
        public ProductAddOrder(int ProductID) : base(ProductID)
        {
            InitializeComponent();
            LoadUsercontrolData();
            AddOrderBtn.Enabled = false;
        }

        //delcare variables and event 
        public event EventHandler AddBtn;
        public int Quantity { get { return Convert.ToInt32(QuantityNumUpDown.Value); } }


        private void LoadUsercontrolData()
        {

            //set that to max value of an order
            QuantityNumUpDown.Maximum = Stock;

            //assign rest of the controls to the variables
            //converting to correct format.
            PriceLbl.Text = "£" + (Price / 100m).ToString("0.00");

            //if no remaining stock then disable adding to basket or changin value as min<=max
            if (Stock <= 0)
            {
                AddOrderBtn.Enabled = false;
                QuantityNumUpDown.Enabled = false;
            }

        }

        private void InitializeComponent()
        {
            AddOrderBtn = new System.Windows.Forms.Button();
            QuantityNumUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            PriceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)QuantityNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // AddOrderBtn
            // 
            AddOrderBtn.Location = new System.Drawing.Point(118, 88);
            AddOrderBtn.Name = "AddOrderBtn";
            AddOrderBtn.Size = new System.Drawing.Size(168, 49);
            AddOrderBtn.TabIndex = 3;
            AddOrderBtn.Text = "Add To Basket";
            AddOrderBtn.UseVisualStyleBackColor = true;
            AddOrderBtn.Click += AddOrderBtn_Click;
            // 
            // QuantityNumUpDown
            // 
            QuantityNumUpDown.Location = new System.Drawing.Point(118, 59);
            QuantityNumUpDown.Name = "QuantityNumUpDown";
            QuantityNumUpDown.Size = new System.Drawing.Size(168, 23);
            QuantityNumUpDown.TabIndex = 4;
            QuantityNumUpDown.ValueChanged += QuantityNumUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(118, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Price";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new System.Drawing.Point(151, 41);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new System.Drawing.Size(0, 15);
            PriceLbl.TabIndex = 6;
            // 
            // ProductAddOrder
            // 
            Controls.Add(PriceLbl);
            Controls.Add(label1);
            Controls.Add(QuantityNumUpDown);
            Controls.Add(AddOrderBtn);
            Name = "ProductAddOrder";
            Size = new System.Drawing.Size(293, 145);
            ((System.ComponentModel.ISupportInitialize)QuantityNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button AddOrderBtn;
        private System.Windows.Forms.NumericUpDown QuantityNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLbl;

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            AddBtn.Invoke(this, e);
        }

        private void QuantityNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            //if < 0 items then 
            if(QuantityNumUpDown.Value < 0) 
            {
                //disable button if 0
                AddOrderBtn.Enabled = false;
            }
            else
            {
                //otherwise enable button
                AddOrderBtn.Enabled=true;
            }
        }

    }
}
