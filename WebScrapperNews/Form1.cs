using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
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

        private string[] getDisallows(string url)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                string robotText = "/robots.txt";
                string startText = "https://";
                string combinedUrl = startText + url + robotText;
                HtmlAgilityPack.HtmlDocument doc = web.Load(combinedUrl);

                if (doc.DocumentNode != null)
                {
                    var client = new System.Net.Http.HttpClient();
                    string content = client.GetStringAsync(combinedUrl).Result;


                    string pattern = @"User-agent: \*\r?\n(?:(?:Sitemap: .*?\r?\n)?)((?:Disallow: .*?\r?\n)*)";

                    Regex regex = new Regex(pattern, RegexOptions.Multiline | RegexOptions.Singleline);

                    Match match = regex.Match(content);

                    if (match.Success)
                    {
                        string[] disallows = match.Groups[1].Value.Split(new[] {"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries).Select(line => line.Replace("Disallow: ", "").Trim()).ToArray();
                        return disallows;
                        // ResultBox.Text = match.Value;
                    }
                    else
                    {
                        return new string[] {};
                        // ResultBox.Text = content;

                    }
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

            return new string[] { "test", "test" };
        }

        
        private void GetArticle(string[] disallows, Match match)
        {
            foreach (var disallow in disallows)
            {
                string url = match.Groups[1].Value;

                if (!CheckIfUrlIllegal(disallows, match))
                {
                    HtmlWeb web = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                    if (doc.DocumentNode != null)
                    {
                        string test = doc.DocumentNode.OuterHtml;
                        bool res = CheckIfKeyMatch(test);
                        
                        if (res)
                        {
                            ResultBox.Text = url;
                        }

                    }
                }

                
            }
        }
        private bool CheckIfUrlIllegal(string[] disallows, Match match)
        {
            foreach (var disallow in disallows)
            {
                string url = match.Groups[1].Value;
                bool illegal = url.IndexOf(disallow, StringComparison.OrdinalIgnoreCase) >= 0;

                if (illegal)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckIfKeyMatch(string text)
        {
            foreach (var keyword in KeyWords)
            {
                
                bool match = text.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;

                if (match)
                {
                    return true;
                }
            }
            return false;
        }
        private void FindArticles(string[] disallows, MatchCollection matches)
        {
            foreach (Match match in matches)
            {
                string content = match.Groups[0].Value;

                string pattern = @"href=""([^""]+)""";

                // Create the regex object
                Regex regex = new Regex(pattern);

                // Find all matches
                Match matchUrl = regex.Match(content);

                GetArticle(disallows, matchUrl);
                //ResultBox.Text = matchUrl.Groups[1].Value;

            }
        }

        private void ScrapePage(string[] disallows, string url)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                if (doc.DocumentNode != null)
                {
                    string test = doc.DocumentNode.OuterHtml;
                    //ResultBox.Text = test;

                    //string articlePattern = @"<article\b[^>]*>.*?<\/article>";
                    //string sectionPattern = @"<section\b[^>]*>.*?<\/section>";
                    string combinedPattern = @"<(section|article)\b[^>]*>.*?<\/(section|article)>";


                    Regex regex = new Regex(combinedPattern, RegexOptions.Multiline | RegexOptions.Singleline);

                    MatchCollection matches = regex.Matches(test);


                    if (matches.Count > 0)
                    {
                        //ResultBox.Text = matches[6].Value;
                        FindArticles(disallows, matches);
                    }
                    else
                    {
                        MessageBox.Show("No articles found on this page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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
                string[] disallows = getDisallows(WebSites[i]);
                string url = "https://" + WebSites[i];
                ScrapePage (disallows , url);
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
