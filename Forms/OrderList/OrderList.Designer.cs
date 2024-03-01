namespace NEA1.Forms.OrderList
{
    partial class OrderList
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
            OrdersFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // OrdersFlowPanel
            // 
            OrdersFlowPanel.AutoScroll = true;
            OrdersFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            OrdersFlowPanel.Location = new System.Drawing.Point(0, 0);
            OrdersFlowPanel.Name = "OrdersFlowPanel";
            OrdersFlowPanel.Size = new System.Drawing.Size(900, 537);
            OrdersFlowPanel.TabIndex = 0;
            // 
            // OrderList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(OrdersFlowPanel);
            Name = "OrderList";
            Size = new System.Drawing.Size(900, 537);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrdersFlowPanel;
    }
}
