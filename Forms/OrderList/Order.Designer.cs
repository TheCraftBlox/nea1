namespace NEA1.Forms.OrderList
{
    partial class Order
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
            components = new System.ComponentModel.Container();
            TimeLbl = new System.Windows.Forms.Label();
            ConfirmBtn = new System.Windows.Forms.Button();
            OrderLbl = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // TimeLbl
            // 
            TimeLbl.AutoSize = true;
            TimeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            TimeLbl.Location = new System.Drawing.Point(9, 10);
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new System.Drawing.Size(48, 21);
            TimeLbl.TabIndex = 0;
            TimeLbl.Text = "Time";
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackgroundImage = Properties.Resources.confirm;
            ConfirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ConfirmBtn.Location = new System.Drawing.Point(164, 3);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new System.Drawing.Size(30, 30);
            ConfirmBtn.TabIndex = 1;
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // OrderLbl
            // 
            OrderLbl.AutoSize = true;
            OrderLbl.Location = new System.Drawing.Point(9, 31);
            OrderLbl.Name = "OrderLbl";
            OrderLbl.Size = new System.Drawing.Size(0, 15);
            OrderLbl.TabIndex = 2;
            // 
            // Order
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(OrderLbl);
            Controls.Add(ConfirmBtn);
            Controls.Add(TimeLbl);
            Name = "Order";
            Size = new System.Drawing.Size(212, 125);
            Load += Order_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label OrderLbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
