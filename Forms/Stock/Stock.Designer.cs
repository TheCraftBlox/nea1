namespace NEA1.Forms.Stock
{
    partial class Stock
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
            StockFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // StockFlowPanel
            // 
            StockFlowPanel.AutoScroll = true;
            StockFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            StockFlowPanel.Location = new System.Drawing.Point(0, 0);
            StockFlowPanel.Name = "StockFlowPanel";
            StockFlowPanel.Size = new System.Drawing.Size(645, 357);
            StockFlowPanel.TabIndex = 0;
            // 
            // Stock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(StockFlowPanel);
            Name = "Stock";
            Size = new System.Drawing.Size(645, 357);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel StockFlowPanel;
        private ProductStock productStock1;
    }
}
