using System;
using System.Drawing;
using System.Dynamic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using MetroFramework.Forms;
using HtmlAgilityPack;
using System.IO;

namespace TitleSvg
{

    //This program uses the Metro Framework https://github.com/thielj/MetroFramework
    public partial class Form1 : MetroForm
    {
        private int index = 1;
        private string path = null;
        private bool hastitle = true;
        private string text;

        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Title = "Find SVG";
            open.Filter = "SVG files (*.svg)|*.svg";
            open.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                index = setIndex();
                forward.Enabled = true;
                back.Enabled = true;
                titleBox.Enabled = true;
                wikiText.ReadOnly = false;
                wikiChangeButton.Enabled = true;
                ReadSvg();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            webBrowser1.Width = (flowLayoutPanel1.Width - flowLayoutPanel2.Width - 20);
            wikiText.Height = (flowLayoutPanel1.Height / 3);
            webBrowser1.Height = (flowLayoutPanel1.Height - wikiText.Height - wikiLabel.Height - metroLabel1.Height - 12);
            wikiText.Width = (flowLayoutPanel1.Width - flowLayoutPanel2.Width - 20);
            linkLabel.Width = (webBrowser1.Width - (wikiLabel.Width + 5));
            file.Width = (webBrowser1.Width - (metroLabel1.Width + 5));
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            if (titleBox.Text.Length > 0 && path != null)
            {
                changeButton.Enabled = true;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var doc = XDocument.Load(path);
            if (hastitle == true)
            {
                doc.Root.Element("title").Value = titleBox.Text;
                doc.Root.Element("wiki").Value = wikiText.Text;
            }
            else
            {
                XObject title = new XElement("title", titleBox.Text);
                doc.Root.Add(title);
                XObject wiki = new XElement("wiki", wikiText.Text);
                doc.Root.Add(wiki);
                hastitle = true;
            }
            doc.Save(path);
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (index > 1 && path != null)
            {
                index --;
                Parse();
                wikiText.Text = "";
                linkLabel.Text = "";
                if(readFile() == false)
                {
                    ReadSvg();
                }
            }
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                index++;
                Parse();
                wikiText.Text = "";
                linkLabel.Text = "";
                if (readFile() == false)
                {
                    ReadSvg();
                }
            }
        }

        private void ReadSvg()
        {
            try
            {
                titleBox.Enabled = true;
                file.Text = path;
                hastitle = true;

                webBrowser1.DocumentText =
                    "<!DOCTYPE html><head><meta http-equiv='X-UA-Compatible' content='IE=9'/></head><html lang='en'>" +
                    "<body style='background-color: rgb(30, 30, 30);'>" +
                    "<div style='position: fixed; text-align: center; left: 0; right: 0; top: 0; bottom: 0;'>" +
                    "<img style='height: 100%; width: 100%;' src = '" + path + "'>" +
                    "<p style='color: white; width: 100%; height: 100%; font-size: 10vw; font-family: sans-serif;'>" + text + "</p></div></body></html>";


                var doc = XDocument.Load(path);
                titleBox.Text = doc.Root.Element("title").Value;
                wikiText.Text = doc.Root.Element("wiki").Value;
                changeButton.Enabled = false;
            }
            catch (Exception)
            {
                titleBox.Text = "Add A Title";
                changeButton.Enabled = false;
                hastitle = false;
            }
        }

        private void Parse()
        {
            char[] delims = {'\\', '.'};
            var words = path.Split(delims);
            var regex = new Regex(@"^\d+$");

            for (var i = 0; i < words.Length; i++)
            {
                if (regex.IsMatch(words[i]))
                {
                    words[i] = index.ToString();
                    words[i] = words[i] + ".";
                    path = string.Join("", words);
                    break;
                }
                words[i] = words[i] + "\\";
            }
        }

        private int setIndex()
        {
            char[] delims = { '\\', '.' };
            var words = path.Split(delims);
            var regex = new Regex(@"^\d+$");
            int index = 1;

            for (var i = 0; i < words.Length; i++)
            {
                if (regex.IsMatch(words[i]))
                {
                    index = Convert.ToInt16(words[i]);
                    break;
                }
            }
            return index;
        }


        private void linkLabel_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel.Text);
        }

        private void wikiChangeButton_Click(object sender, EventArgs e)
        {
            var doc = XDocument.Load(path);
            doc.Root.Element("wiki").Value = wikiText.Text;
            doc.Save(path);
            wikiChangeButton.Enabled = false;
        }

        private void wikiText_TextChanged(object sender, EventArgs e)
        {
            wikiChangeButton.Enabled = true; 
        }


        private bool readFile()
        {
            bool status = false;
            try
            {
                File.ReadAllText(path);
            }
            catch (Exception)
            {
                string format = Regex.Replace(path, @"\b.svg\b", ".txt");
                try
                {
                    StreamReader txt = new StreamReader(format);
                    file.Text = format;
                    titleBox.Text = "";
                    titleBox.Enabled = false;
                    wikiText.ReadOnly = true;
                    wikiChangeButton.Enabled = false;
                    text = txt.ReadLine();
                    webBrowser1.DocumentText = "<!DOCTYPE html><head><meta http-equiv='X-UA-Compatible' content='IE=9'/></head><html lang='en'>" +
                        "<body style='background-color: rgb(30, 30, 30);'>" +
                        "<div style='position: fixed; text-align: center; left: 0; right: 0; top: 0; bottom: 0;'>" +
                        "<p style='color: white; width: 100%; height: 100%; font-size: 10vw; font-family: sans-serif;'>" + text + "</p></div></body></html>";
                    status = true;
                }
                catch (Exception)
                {

                }
            }
            return status;
        }
    }
}