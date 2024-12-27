namespace WebScrapperNews
{
    partial class WebScrapper
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
            this.SiteTextBox = new System.Windows.Forms.TextBox();
            this.addSiteButton = new System.Windows.Forms.Button();
            this.SiteListBox = new System.Windows.Forms.ListBox();
            this.DeleteSiteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SiteTextBox
            // 
            this.SiteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteTextBox.Location = new System.Drawing.Point(65, 74);
            this.SiteTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SiteTextBox.Name = "SiteTextBox";
            this.SiteTextBox.Size = new System.Drawing.Size(468, 34);
            this.SiteTextBox.TabIndex = 0;
            // 
            // addSiteButton
            // 
            this.addSiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.addSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSiteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addSiteButton.Location = new System.Drawing.Point(550, 68);
            this.addSiteButton.Name = "addSiteButton";
            this.addSiteButton.Size = new System.Drawing.Size(298, 46);
            this.addSiteButton.TabIndex = 1;
            this.addSiteButton.Text = "Legg til Side";
            this.addSiteButton.UseVisualStyleBackColor = false;
            this.addSiteButton.Click += new System.EventHandler(this.addSiteButton_Click);
            // 
            // SiteListBox
            // 
            this.SiteListBox.FormattingEnabled = true;
            this.SiteListBox.ItemHeight = 29;
            this.SiteListBox.Location = new System.Drawing.Point(65, 126);
            this.SiteListBox.Name = "SiteListBox";
            this.SiteListBox.Size = new System.Drawing.Size(783, 207);
            this.SiteListBox.TabIndex = 2;
            // 
            // DeleteSiteButton
            // 
            this.DeleteSiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DeleteSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSiteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteSiteButton.Location = new System.Drawing.Point(65, 344);
            this.DeleteSiteButton.Name = "DeleteSiteButton";
            this.DeleteSiteButton.Size = new System.Drawing.Size(783, 44);
            this.DeleteSiteButton.TabIndex = 3;
            this.DeleteSiteButton.Text = "Fjern Side";
            this.DeleteSiteButton.UseVisualStyleBackColor = false;
            this.DeleteSiteButton.Click += new System.EventHandler(this.DeleteSiteButton_Click);
            // 
            // WebScrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(914, 410);
            this.Controls.Add(this.DeleteSiteButton);
            this.Controls.Add(this.SiteListBox);
            this.Controls.Add(this.addSiteButton);
            this.Controls.Add(this.SiteTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WebScrapper";
            this.Text = "Nyhets Web Scrapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SiteTextBox;
        private System.Windows.Forms.Button addSiteButton;
        private System.Windows.Forms.ListBox SiteListBox;
        private System.Windows.Forms.Button DeleteSiteButton;
    }
}

