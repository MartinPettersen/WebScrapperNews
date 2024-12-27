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
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.AddKeyButton = new System.Windows.Forms.Button();
            this.KeyListBox = new System.Windows.Forms.ListBox();
            this.RemoveKeyButton = new System.Windows.Forms.Button();
            this.RunCrawlerButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SiteTextBox
            // 
            this.SiteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteTextBox.Location = new System.Drawing.Point(65, 74);
            this.SiteTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SiteTextBox.Name = "SiteTextBox";
            this.SiteTextBox.Size = new System.Drawing.Size(316, 34);
            this.SiteTextBox.TabIndex = 0;
            // 
            // addSiteButton
            // 
            this.addSiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.addSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSiteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addSiteButton.Location = new System.Drawing.Point(401, 68);
            this.addSiteButton.Name = "addSiteButton";
            this.addSiteButton.Size = new System.Drawing.Size(298, 46);
            this.addSiteButton.TabIndex = 1;
            this.addSiteButton.Text = "Legg til Side";
            this.addSiteButton.UseVisualStyleBackColor = false;
            this.addSiteButton.Click += new System.EventHandler(this.addSiteButton_Click);
            // 
            // SiteListBox
            // 
            this.SiteListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.SiteListBox.FormattingEnabled = true;
            this.SiteListBox.ItemHeight = 29;
            this.SiteListBox.Location = new System.Drawing.Point(65, 126);
            this.SiteListBox.Name = "SiteListBox";
            this.SiteListBox.Size = new System.Drawing.Size(634, 207);
            this.SiteListBox.TabIndex = 2;
            // 
            // DeleteSiteButton
            // 
            this.DeleteSiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DeleteSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSiteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteSiteButton.Location = new System.Drawing.Point(65, 344);
            this.DeleteSiteButton.Name = "DeleteSiteButton";
            this.DeleteSiteButton.Size = new System.Drawing.Size(634, 44);
            this.DeleteSiteButton.TabIndex = 3;
            this.DeleteSiteButton.Text = "Fjern Side";
            this.DeleteSiteButton.UseVisualStyleBackColor = false;
            this.DeleteSiteButton.Click += new System.EventHandler(this.DeleteSiteButton_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextBox.Location = new System.Drawing.Point(65, 425);
            this.KeyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(316, 34);
            this.KeyTextBox.TabIndex = 6;
            // 
            // AddKeyButton
            // 
            this.AddKeyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.AddKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddKeyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddKeyButton.Location = new System.Drawing.Point(401, 419);
            this.AddKeyButton.Name = "AddKeyButton";
            this.AddKeyButton.Size = new System.Drawing.Size(298, 46);
            this.AddKeyButton.TabIndex = 7;
            this.AddKeyButton.Text = "Legg til Søkeord";
            this.AddKeyButton.UseVisualStyleBackColor = false;
            this.AddKeyButton.Click += new System.EventHandler(this.AddKeyButton_Click);
            // 
            // KeyListBox
            // 
            this.KeyListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.KeyListBox.FormattingEnabled = true;
            this.KeyListBox.ItemHeight = 29;
            this.KeyListBox.Location = new System.Drawing.Point(65, 484);
            this.KeyListBox.Name = "KeyListBox";
            this.KeyListBox.Size = new System.Drawing.Size(634, 207);
            this.KeyListBox.TabIndex = 8;
            // 
            // RemoveKeyButton
            // 
            this.RemoveKeyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.RemoveKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveKeyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveKeyButton.Location = new System.Drawing.Point(65, 697);
            this.RemoveKeyButton.Name = "RemoveKeyButton";
            this.RemoveKeyButton.Size = new System.Drawing.Size(634, 44);
            this.RemoveKeyButton.TabIndex = 9;
            this.RemoveKeyButton.Text = "Fjern Søkeord";
            this.RemoveKeyButton.UseVisualStyleBackColor = false;
            this.RemoveKeyButton.Click += new System.EventHandler(this.RemoveKeyButton_Click);
            // 
            // RunCrawlerButton
            // 
            this.RunCrawlerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.RunCrawlerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunCrawlerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunCrawlerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.RunCrawlerButton.Location = new System.Drawing.Point(726, 68);
            this.RunCrawlerButton.Name = "RunCrawlerButton";
            this.RunCrawlerButton.Size = new System.Drawing.Size(417, 97);
            this.RunCrawlerButton.TabIndex = 10;
            this.RunCrawlerButton.Text = "Kjør";
            this.RunCrawlerButton.UseVisualStyleBackColor = false;
            // 
            // ResultBox
            // 
            this.ResultBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 29;
            this.ResultBox.Location = new System.Drawing.Point(726, 186);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(417, 555);
            this.ResultBox.TabIndex = 11;
            // 
            // WebScrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1205, 806);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.RunCrawlerButton);
            this.Controls.Add(this.RemoveKeyButton);
            this.Controls.Add(this.KeyListBox);
            this.Controls.Add(this.AddKeyButton);
            this.Controls.Add(this.KeyTextBox);
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
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button AddKeyButton;
        private System.Windows.Forms.ListBox KeyListBox;
        private System.Windows.Forms.Button RemoveKeyButton;
        private System.Windows.Forms.Button RunCrawlerButton;
        private System.Windows.Forms.ListBox ResultBox;
    }
}

