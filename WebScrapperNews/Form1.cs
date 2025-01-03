using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
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
        List<(string Url, string[] Keywords)> Results = new List<(string Url, string[] Keywords)>();


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
                        string[] disallows = match.Groups[1].Value.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(line => line.Replace("Disallow: ", "").Trim()).ToArray();
                        return disallows;
                        // ResultBox.Text = match.Value;
                    }
                    else
                    {
                        return new string[] { };
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
            List<string> MatchingKeys = new List<string>();
            string url = match.Groups[1].Value;
            //ResultBox.AppendText($"Attempting to load URL: {url}\n");
            //MessageBox.Show($"Attempting to load URL: {url}\n");

            if (string.IsNullOrWhiteSpace(url))
            {
                return;
            }
            if (url.StartsWith("#"))
            {
                return;
            }
            foreach (var disallow in disallows)
            {

                if (!CheckIfUrlIllegal(disallows, match))
                {
                    HtmlWeb web = new HtmlWeb();
                    web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";

                    HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                    if (doc.DocumentNode != null)
                    {
                        try
                        {

                            string test = doc.DocumentNode.OuterHtml;
                            List<string> Matches = CheckIfKeyMatch(test);

                            if (Matches.Count > 0)
                            {
                                //ResultBox.Text = url;
                                //Results.Add((url, MatchingKeys.ToArray()));

                                bool exists = MatchingKeys.Contains(Matches[0]);
                                if (!exists)
                                {
                                    MatchingKeys.AddRange(Matches);
                                    DisplayResults();

                                }
                            }
                        }
                        catch (Exception e)
                        {
                            //ResultBox.AppendText($"Failed with URL: {url}\nError: {e.Message}\nStack Trace: {e.StackTrace}\n\n");
                            //MessageBox.Show($"Failed with URL: {url}\nError: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(e.ToString());

                        }

                    }
                }


            }

            if (MatchingKeys.Count > 0)
            {
                Results.Add((url, MatchingKeys.ToArray()));
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

        private List<string> CheckIfKeyMatch(string text)
        {
            List<string> MatchingKeys = new List<string>();
            foreach (var keyword in KeyWords)
            {

                bool match = text.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;

                if (match)
                {
                    MatchingKeys.Add(keyword);
                }
            }
            return MatchingKeys;
        }

        private void DisplayResults()
        {
            ResultBox.Clear();
            ResultBox.DetectUrls = true;
            ResultBox.ReadOnly = true;

            StringBuilder sb = new StringBuilder();
            foreach ((string Url, string[] Keywords) result in Results)
            {

                sb.AppendLine("" + result.Url + ": " + string.Join(", ", result.Keywords) + "\n");
            }
            ResultBox.Text = sb.ToString();
        }
        private void FindArticles(string[] disallows, MatchCollection matches)
        {
            foreach (Match match in matches)
            {
                string content = match.Groups[0].Value;

                string pattern = @"href=""([^""]+)(?<!\.(?:css|js|png|jpg|jpeg|gif|svg|ico|woff|woff2|ttf|eot))""";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

                Match matchUrl = regex.Match(content);

                //ResultBox.AppendText($"Attempting to load URL: {matchUrl}\n");
                GetArticle(disallows, matchUrl);
                //ResultBox.Text = matchUrl.Groups[1].Value;


            }
            RunCrawlerButton.Text = "Kjør";
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

            for (int i = 0; i < WebSites.Count; i++)
            {
                string combinedUrl = startText + WebSites[i] + robotText;
                string[] disallows = getDisallows(WebSites[i]);
                string url = "https://" + WebSites[i];
                ScrapePage(disallows, url);
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
            SiteTextBox.Text = "";
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
            KeyTextBox.Text = "";
        }

        private void RemoveKeyButton_Click(object sender, EventArgs e)
        {
            KeyWords.RemoveAt(KeyListBox.SelectedIndex);
            KeyListBox.DataSource = null;
            KeyListBox.DataSource = KeyWords;
        }

        private void RunCrawlerButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            ResultBox.Clear();
            Results.Clear();
            RunCrawlerButton.Text = "Kjører...";
            ScrapeWeb();
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ResultBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.LinkText,
                UseShellExecute = true
            });
        }
    }
}