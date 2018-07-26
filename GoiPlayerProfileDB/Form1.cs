using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronOcr;
using System.Runtime.Serialization.Formatters.Binary;

namespace GoiPlayerProfileDB
{
    public partial class Form1 : Form
    {

        private Bitmap img;
        private string saveFile;
        private Config config;
        private static string[] shipNames = { "Magnate", "Pyramidion", "Crusader", "Corsair", "Goldfish", "Spire", "Mobula", "Squid", "Stormbreaker", "Junker", "Galleon", "Shrike" };

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("./config.cfg"))
            {
                FileStream fs = new FileStream("./config.cfg", FileMode.Open, FileAccess.Read);
                config = (new BinaryFormatter()).Deserialize(fs) as Config;
                fs.Close();
            }
            else
            {
                config = new Config();
                string selfPath = Path.GetFullPath("./");
                config.openPath = selfPath;
                config.savePath = selfPath;
            }
        }

        private void findFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = config.openPath;
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                fileInputText.Text = openFileDialog1.FileName;
                config.openPath = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void fileInputText_TextChanged(object sender, EventArgs e)
        {
            img = new Bitmap(fileInputText.Text);
            previewImageBox.Image = img;
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            if(saveFile.Length == 0)
            {
                return;
            }
            scanBtn.Enabled = false;

            FileStream fs = new FileStream("./config.cfg", FileMode.OpenOrCreate, FileAccess.Write);
            (new BinaryFormatter()).Serialize(fs, config);
            fs.Close();

            AdvancedOcr ocr = new AdvancedOcr();
            ocr.ReadBarCodes = false;
            ocr.Strategy = AdvancedOcr.OcrStrategy.Advanced;
            ocr.DetectWhiteTextOnDarkBackgrounds = true;
            OcrResult result = ocr.Read(img);

            SaveResults(result);

            scanBtn.Enabled = true;
        }

        private void SaveResults(OcrResult result)
        {
            FileStream fileStream = new FileStream(saveFile, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter stream = new StreamWriter(fileStream);

            var pages = result.Pages;
            foreach (var page in pages)
            {
                stream.WriteLine("Page\tPage No\tFont\tWidth\tHeight\tWord Count\n\t" + page.PageNumber + "\t" + page.FontName + " (" + page.FontSize + ")\t" + page.Width + "\t" + page.Height + "\t" + page.WordCount);
                var pars = page.Paragraphs;
                foreach (var par in pars)
                {
                    stream.WriteLine("\tParagraph\tNo.\tFont\tWidth\tHeight\tWord Count\tConfidence\n\t\t" + par.ParagraphNumber + "\t" + par.FontName + " (" + par.FontSize + ")\t" + par.Width + "\t" + par.Height + "\t" + par.WordCount + "\t" + par.Confidence + "\n\t\tLine\tLine No.\tWidth\tHeight\tWord Count\tConfidence\tText");
                    var lines = par.Lines;
                    foreach (var line in lines)
                    {
                        stream.WriteLine("\t\t\t" + line.LineNumber + "\t" + line.Width + "\t" + line.Height + "\t" + line.WordCount + "\t" + line.Confidence + "\t" + line.Text);
                    }
                }
            }
            stream.Flush();
            stream.Close();
        }

        private void ParseOcrResult(OcrResult result)
        {
            var pages = result.Pages;
            foreach(var page in pages)
            {
                var lines = page.LinesOfText;
                foreach(var line in lines)
                {
                    string ending = line.Words.Last().Text;

                    if(ending.Equals("A") || ending.Equals("a") || ending.Equals("5") || ending.Equals("3"))
                    {

                    }
                }
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = config.savePath;
            var result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                saveFile = saveFileDialog1.FileName;
                outputFileTextBox.Text = saveFileDialog1.FileName;
                config.savePath = Path.GetDirectoryName(saveFile);
            }
        }
    }
}
