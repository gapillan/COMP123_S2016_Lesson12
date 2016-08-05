namespace COMP123_S2016_Lesson12
{
    partial class ListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.ListViewBox = new System.Windows.Forms.GroupBox();
            this.ProvinceListBox = new System.Windows.Forms.ListBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.ListViewBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(189, 346);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(83, 31);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ListViewBox
            // 
            this.ListViewBox.Controls.Add(this.ProvinceListBox);
            this.ListViewBox.Location = new System.Drawing.Point(12, 12);
            this.ListViewBox.Name = "ListViewBox";
            this.ListViewBox.Size = new System.Drawing.Size(260, 208);
            this.ListViewBox.TabIndex = 1;
            this.ListViewBox.TabStop = false;
            this.ListViewBox.Text = "My List View";
            // 
            // ProvinceListBox
            // 
            this.ProvinceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceListBox.FormattingEnabled = true;
            this.ProvinceListBox.ItemHeight = 20;
            this.ProvinceListBox.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.ProvinceListBox.Location = new System.Drawing.Point(6, 19);
            this.ProvinceListBox.Name = "ProvinceListBox";
            this.ProvinceListBox.Size = new System.Drawing.Size(225, 164);
            this.ProvinceListBox.Sorted = true;
            this.ProvinceListBox.TabIndex = 0;
            this.ProvinceListBox.SelectedIndexChanged += new System.EventHandler(this.ProvinceListBox_SelectedIndexChanged);
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceLabel.Location = new System.Drawing.Point(15, 234);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(69, 16);
            this.ProvinceLabel.TabIndex = 2;
            this.ProvinceLabel.Text = "Province";
            // 
            // ProvinceTextBox
            // 
            this.ProvinceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProvinceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProvinceTextBox.Location = new System.Drawing.Point(18, 254);
            this.ProvinceTextBox.Name = "ProvinceTextBox";
            this.ProvinceTextBox.ReadOnly = true;
            this.ProvinceTextBox.Size = new System.Drawing.Size(225, 22);
            this.ProvinceTextBox.TabIndex = 3;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 389);
            this.Controls.Add(this.ProvinceTextBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.ListViewBox);
            this.Controls.Add(this.NextButton);
            this.Name = "ListForm";
            this.Text = "Form1";
            this.ListViewBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox ListViewBox;
        private System.Windows.Forms.ListBox ProvinceListBox;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.TextBox ProvinceTextBox;
    }
}

