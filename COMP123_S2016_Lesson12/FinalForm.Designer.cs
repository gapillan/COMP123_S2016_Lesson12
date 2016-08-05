namespace COMP123_S2016_Lesson12
{
    partial class FinalForm
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
            this.ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProvinceTextBox
            // 
            this.ProvinceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProvinceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProvinceTextBox.Location = new System.Drawing.Point(12, 56);
            this.ProvinceTextBox.Name = "ProvinceTextBox";
            this.ProvinceTextBox.ReadOnly = true;
            this.ProvinceTextBox.Size = new System.Drawing.Size(225, 22);
            this.ProvinceTextBox.TabIndex = 5;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceLabel.Location = new System.Drawing.Point(9, 36);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(69, 16);
            this.ProvinceLabel.TabIndex = 4;
            this.ProvinceLabel.Text = "Province";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 219);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(83, 31);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ProvinceTextBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Name = "FinalForm";
            this.Text = "FinalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProvinceTextBox;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.Button BackButton;
    }
}