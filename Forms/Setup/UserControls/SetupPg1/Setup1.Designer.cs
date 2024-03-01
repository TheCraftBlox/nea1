namespace NEA1.Forms.Setup.UserControls
{
    partial class Setup1
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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            yesbutton = new System.Windows.Forms.RadioButton();
            noButton = new System.Windows.Forms.RadioButton();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            fileSelectedLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(15, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(356, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the setup:";
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(532, 332);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 3;
            button1.Text = "next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 95);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(240, 15);
            label2.TabIndex = 4;
            label2.Text = "Is there already a database on your network?";
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(438, 332);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(88, 27);
            button2.TabIndex = 5;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // yesbutton
            // 
            yesbutton.AutoSize = true;
            yesbutton.Location = new System.Drawing.Point(23, 126);
            yesbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            yesbutton.Name = "yesbutton";
            yesbutton.Size = new System.Drawing.Size(42, 19);
            yesbutton.TabIndex = 1;
            yesbutton.TabStop = true;
            yesbutton.Text = "Yes";
            yesbutton.UseVisualStyleBackColor = true;
            yesbutton.CheckedChanged += yesbutton_CheckedChanged;
            // 
            // noButton
            // 
            noButton.AutoSize = true;
            noButton.Location = new System.Drawing.Point(23, 152);
            noButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            noButton.Name = "noButton";
            noButton.Size = new System.Drawing.Size(41, 19);
            noButton.TabIndex = 2;
            noButton.TabStop = true;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.CheckedChanged += noButton_CheckedChanged;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new System.Drawing.Point(23, 204);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(125, 27);
            button3.TabIndex = 6;
            button3.Text = "Choose Location";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 186);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // fileSelectedLabel
            // 
            fileSelectedLabel.AutoSize = true;
            fileSelectedLabel.Location = new System.Drawing.Point(20, 234);
            fileSelectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fileSelectedLabel.Name = "fileSelectedLabel";
            fileSelectedLabel.Size = new System.Drawing.Size(95, 15);
            fileSelectedLabel.TabIndex = 10;
            fileSelectedLabel.Text = "fileSelectedLabel";
            fileSelectedLabel.Click += label4_Click;
            // 
            // Setup1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(fileSelectedLabel);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(noButton);
            Controls.Add(yesbutton);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Setup1";
            Size = new System.Drawing.Size(635, 375);
            Load += Setup1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton yesbutton;
        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label fileSelectedLabel;
    }
}
