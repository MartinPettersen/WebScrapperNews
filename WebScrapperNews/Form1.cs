﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrapperNews
{
    public partial class WebScrapper : Form
    {

        List<string> WebSites = new List<string>();
        List<string> KeyWords = new List<string>();
        public WebScrapper()
        {
            InitializeComponent();
        }

        private void addSiteButton_Click(object sender, EventArgs e)
        {
            WebSites.Add(SiteTextBox.Text);
            SiteListBox.DataSource = null;
            SiteListBox.DataSource = WebSites;

        }

        private void DeleteSiteButton_Click(object sender, EventArgs e)
        {
            WebSites.RemoveAt(SiteListBox.SelectedIndex);
            SiteListBox.DataSource = null;
            SiteListBox.DataSource = WebSites;
        }

        private void AddKeyButton_Click(object sender, EventArgs e)
        {
            KeyWords.Add(KeyTextBox.Text);
            KeyListBox.DataSource = null;
            KeyListBox.DataSource = KeyWords;
        }

        private void RemoveKeyButton_Click(object sender, EventArgs e)
        {
            KeyWords.RemoveAt(KeyListBox.SelectedIndex);
            KeyListBox.DataSource = null;
            KeyListBox.DataSource = KeyWords;
        }
    }
}
