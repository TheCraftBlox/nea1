namespace NEA1.Forms.ProductList
{
    partial class ProductList
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
            searchTxtBox = new System.Windows.Forms.TextBox();
            SearchButton = new System.Windows.Forms.Button();
            ProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            Add = new System.Windows.Forms.Button();
            clearSearchBtn = new System.Windows.Forms.Button();
            CurrentSelectionLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // searchTxtBox
            // 
            searchTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            searchTxtBox.Location = new System.Drawing.Point(706, 3);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.PlaceholderText = "Search";
            searchTxtBox.Size = new System.Drawing.Size(160, 23);
            searchTxtBox.TabIndex = 0;
            searchTxtBox.KeyDown += searchTxtBox_KeyDown;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            SearchButton.BackgroundImage = Properties.Resources.Search;
            SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            SearchButton.Location = new System.Drawing.Point(872, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(23, 23);
            SearchButton.TabIndex = 1;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ProductsFlowPanel
            // 
            ProductsFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ProductsFlowPanel.AutoScroll = true;
            ProductsFlowPanel.Location = new System.Drawing.Point(3, 72);
            ProductsFlowPanel.Name = "ProductsFlowPanel";
            ProductsFlowPanel.Size = new System.Drawing.Size(897, 465);
            ProductsFlowPanel.TabIndex = 2;
            // 
            // Add
            // 
            Add.Location = new System.Drawing.Point(3, 3);
            Add.Name = "Add";
            Add.Size = new System.Drawing.Size(75, 23);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // clearSearchBtn
            // 
            clearSearchBtn.Location = new System.Drawing.Point(84, 3);
            clearSearchBtn.Name = "clearSearchBtn";
            clearSearchBtn.Size = new System.Drawing.Size(81, 23);
            clearSearchBtn.TabIndex = 5;
            clearSearchBtn.Text = "Clear Search";
            clearSearchBtn.UseVisualStyleBackColor = true;
            clearSearchBtn.Click += clearSearchBtn_Click;
            // 
            // CurrentSelectionLbl
            // 
            CurrentSelectionLbl.AutoSize = true;
            CurrentSelectionLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            CurrentSelectionLbl.Location = new System.Drawing.Point(3, 32);
            CurrentSelectionLbl.Name = "CurrentSelectionLbl";
            CurrentSelectionLbl.Size = new System.Drawing.Size(180, 37);
            CurrentSelectionLbl.TabIndex = 6;
            CurrentSelectionLbl.Text = "All Products:";
            // 
            // ProductList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(CurrentSelectionLbl);
            Controls.Add(clearSearchBtn);
            Controls.Add(Add);
            Controls.Add(ProductsFlowPanel);
            Controls.Add(SearchButton);
            Controls.Add(searchTxtBox);
            Name = "ProductList";
            Size = new System.Drawing.Size(900, 537);
            Load += ProductList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowPanel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button clearSearchBtn;
        private System.Windows.Forms.Label CurrentSelectionLbl;
    }
}
