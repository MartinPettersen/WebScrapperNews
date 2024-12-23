namespace WebScrapperNews
{
    partial class Form1
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
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.addSiteButton = new System.Windows.Forms.Button();
            this.siteListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // siteTextBox
            // 
            this.siteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteTextBox.Location = new System.Drawing.Point(65, 74);
            this.siteTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(468, 34);
            this.siteTextBox.TabIndex = 0;
            // 
            // addSiteButton
            // 
            this.addSiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.addSiteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addSiteButton.Location = new System.Drawing.Point(550, 68);
            this.addSiteButton.Name = "addSiteButton";
            this.addSiteButton.Size = new System.Drawing.Size(298, 46);
            this.addSiteButton.TabIndex = 1;
            this.addSiteButton.Text = "Legg til Side";
            this.addSiteButton.UseVisualStyleBackColor = false;
            this.addSiteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // siteListBox
            // 
            this.siteListBox.FormattingEnabled = true;
            this.siteListBox.ItemHeight = 29;
            this.siteListBox.Location = new System.Drawing.Point(65, 126);
            this.siteListBox.Name = "siteListBox";
            this.siteListBox.Size = new System.Drawing.Size(783, 207);
            this.siteListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(919, 411);
            this.Controls.Add(this.siteListBox);
            this.Controls.Add(this.addSiteButton);
            this.Controls.Add(this.siteTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.Button addSiteButton;
        private System.Windows.Forms.ListBox siteListBox;
    }
}

