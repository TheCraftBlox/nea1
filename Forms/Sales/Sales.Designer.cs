namespace NEA1.Forms.Sales
{
    partial class Sales
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
            revenueOverTime = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            ChartPanel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            LoadBtn1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            tabPage2 = new System.Windows.Forms.TabPage();
            ChartPanel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            ProductComboBox = new System.Windows.Forms.ComboBox();
            LoadBt2 = new System.Windows.Forms.Button();
            revenueOverTime.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // revenueOverTime
            // 
            revenueOverTime.Controls.Add(tabPage1);
            revenueOverTime.Controls.Add(tabPage2);
            revenueOverTime.Dock = System.Windows.Forms.DockStyle.Fill;
            revenueOverTime.Location = new System.Drawing.Point(0, 0);
            revenueOverTime.Name = "revenueOverTime";
            revenueOverTime.SelectedIndex = 0;
            revenueOverTime.Size = new System.Drawing.Size(900, 537);
            revenueOverTime.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ChartPanel);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(892, 509);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Revenue Over Time";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChartPanel
            // 
            ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartPanel.Location = new System.Drawing.Point(3, 34);
            ChartPanel.Name = "ChartPanel";
            ChartPanel.Size = new System.Drawing.Size(886, 472);
            ChartPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(LoadBtn1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(toDateTimePicker);
            panel1.Controls.Add(fromDateTimePicker);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(886, 31);
            panel1.TabIndex = 2;
            // 
            // LoadBtn1
            // 
            LoadBtn1.Location = new System.Drawing.Point(439, 3);
            LoadBtn1.Name = "LoadBtn1";
            LoadBtn1.Size = new System.Drawing.Size(75, 23);
            LoadBtn1.TabIndex = 3;
            LoadBtn1.Text = "Load Chart";
            LoadBtn1.UseVisualStyleBackColor = true;
            LoadBtn1.Click += LoadBtn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(209, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "to";
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new System.Drawing.Point(233, 3);
            toDateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new System.Drawing.Size(200, 23);
            toDateTimePicker.TabIndex = 0;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new System.Drawing.Point(3, 3);
            fromDateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new System.Drawing.Size(200, 23);
            fromDateTimePicker.TabIndex = 1;
            fromDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            fromDateTimePicker.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ChartPanel2);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(892, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product Sales over Time";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChartPanel2
            // 
            ChartPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartPanel2.Location = new System.Drawing.Point(3, 34);
            ChartPanel2.Name = "ChartPanel2";
            ChartPanel2.Size = new System.Drawing.Size(886, 472);
            ChartPanel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(ProductComboBox);
            panel3.Controls.Add(LoadBt2);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(886, 31);
            panel3.TabIndex = 4;
            // 
            // ProductComboBox
            // 
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new System.Drawing.Point(3, 4);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new System.Drawing.Size(130, 23);
            ProductComboBox.TabIndex = 4;
            ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
            // 
            // LoadBt2
            // 
            LoadBt2.Location = new System.Drawing.Point(139, 4);
            LoadBt2.Name = "LoadBt2";
            LoadBt2.Size = new System.Drawing.Size(75, 23);
            LoadBt2.TabIndex = 3;
            LoadBt2.Text = "Load Chart";
            LoadBt2.UseVisualStyleBackColor = true;
            LoadBt2.Click += LoadBt2_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(revenueOverTime);
            Name = "Sales";
            Size = new System.Drawing.Size(900, 537);
            Load += Sales_Load;
            revenueOverTime.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl revenueOverTime;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadBtn1;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Panel ChartPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Button LoadBt2;
    }
}
