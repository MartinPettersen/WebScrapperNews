using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WebScrapperNews
{
    public partial class WebScrapper : Form
    {

        List<string> WebSites = new List<string>();
        List<string> KeyWords = new List<string>();
        List<string> Results = new List<string>();

        public WebScrapper()
        {
            InitializeComponent();
        }


        private void ScrapePage(string url)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                if (doc.DocumentNode != null)
                {
                    //ResultBox.Text = doc.DocumentNode.OuterHtml;
                    //ResultBox.Text = url;
                    var client = new System.Net.Http.HttpClient();
                    string content = client.GetStringAsync(url).Result;
                    ResultBox.Text = content;

                }
                else
                {
                    MessageBox.Show("Failed to load or parse the HTML document.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScrapeWeb()
        {
            string robotText = "/robots.txt";
            string startText = "https://";

            for ( int i = 0; i < WebSites.Count; i++)
            {
                string combinedUrl = startText + WebSites[i] + robotText;
                ScrapePage (combinedUrl);
                //Results.Add(combinedUrl);
            }
            //ResultBox.DataSource = null;
            //ResultBox.DataSource = Results;

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

        private void RunCrawlerButton_Click(object sender, EventArgs e)
        {
            ScrapeWeb();
        }
    }
}
