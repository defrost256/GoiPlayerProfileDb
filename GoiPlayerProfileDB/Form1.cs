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
using System.Text.RegularExpressions;


namespace GoiPlayerProfileDB
{
    public partial class Form1 : Form
    {

        private Bitmap img;
        private string saveFile;
        private Config config;
        

        private List<TextBox> NameTextBoxes = new List<TextBox>();
        private List<Panel> NameCorrectPanels = new List<Panel>();
        private List<LinkLabel> NameCorrectLinkLabels = new List<LinkLabel>();
        private List<Button> NameCorrectButtons = new List<Button>();

        private Dictionary<int, List<string>> bestFitNames;
        private JsonDbManager jsonManager;

        bool scanned = false;

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

            InitMyComponent();

            jsonManager = new JsonDbManager("./goi-playerprofile-db.json");
                       
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

            OcrResult result = OcrManager.OcrImage(img);

            SaveResults(result);
            var parsed = OcrManager.ParseOcrResult(result);

            bestFitNames = new Dictionary<int, List<string>>();

            for(int i = 0; i < 16 && i < parsed.Count; i++)
            {
                var name = parsed[i];
                NameTextBoxes[i].Text = name;
                if (jsonManager.HasName(name))
                {
                    NameCorrectPanels[i].Hide();
                }
                else
                {
                    NameCorrectPanels[i].Show();
                    List<string> bestFit = jsonManager.GetClosestNames(name);
                    if (bestFit.Count > 0)
                    {
                        NameCorrectLinkLabels[i].Text = bestFit[0];
                    }
                    else
                    {
                        NameCorrectLinkLabels[i].Text = "Not found";
                    }
                    bestFitNames.Add(i, bestFit);
                }
            }

            scanned = true;
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

        private void CorrectLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!scanned)
                return;

            LinkLabel label = sender as LinkLabel;
            string labelName = label.Name;

            char c1 = labelName[labelName.Length - 1];
            char c2 = labelName[labelName.Length - 2];

            int labelIdx;

            if(c2 < 58 && c2 > 47)
            {
                labelIdx = int.Parse("" + c2 + c1) - 1;
            }
            else
            {
                labelIdx = int.Parse("" + c1) - 1;
            }

            NameTextBoxes[labelIdx].Text = label.Text;
            NameCorrectPanels[labelIdx].Hide();
        }

        private void CorrectButtonClicked(object sender, EventArgs e)
        {
            if (!scanned)
                return;

            Button button = sender as Button;
            string btnName = button.Name;

            char c1 = btnName[btnName.Length - 1];
            char c2 = btnName[btnName.Length - 2];

            int btnIdx;

            if(c2 < 58 && c2 > 47)
            {
                btnIdx = int.Parse("" + c2 + c1) - 1;
            }
            else
            {
                btnIdx = int.Parse("" + c1) - 1;
            }

            ChooseFitNameDialog dialog = new ChooseFitNameDialog
            {
                Names = bestFitNames[btnIdx]
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                NameTextBoxes[btnIdx].Text = dialog.SelectedName;
                NameCorrectPanels[btnIdx].Hide();
            }
        }

        private void InitMyComponent()
        {
            string textboxNameBase = "nameResultTextBox";
            string panelNameBase = "nameCorrectPanel";
            string linkLabelNameBase = "nameCorrectLabel";
            string buttonNameBase = "nameCorrectBtn1";

            blueTeamFlow.SuspendLayout();
            redTeamFlow.SuspendLayout();

            for (int i = 1; i <= 16; i++)
            {
                var outerFlowLayout = new FlowLayoutPanel();
                var nameTextBox = new TextBox();
                var nameCorrectFlow = new FlowLayoutPanel();
                var textLabel = new Label();
                var linkLabel = new LinkLabel();
                var nameCorrectBtn = new Button();

                outerFlowLayout.SuspendLayout();
                nameCorrectFlow.SuspendLayout();

                (i <= 8 ? redTeamFlow : blueTeamFlow).Controls.Add(outerFlowLayout);

                outerFlowLayout.Controls.Add(nameTextBox);
                outerFlowLayout.Controls.Add(nameCorrectFlow);
                outerFlowLayout.FlowDirection = FlowDirection.TopDown;
                outerFlowLayout.Location = new Point(3, 0);
                outerFlowLayout.Margin = new Padding(0, 0, 0, 0);
                outerFlowLayout.Name = "outerFlowLayoutPanel" + i;
                outerFlowLayout.Size = new Size(274, 41);
                outerFlowLayout.TabIndex = (i - 1) % 8;

                nameTextBox.Location = new Point(0, 0);
                nameTextBox.Margin = new Padding(0, 0, 0, 0);
                nameTextBox.Name = textboxNameBase + i;
                nameTextBox.Size = new Size(271, 20);
                nameTextBox.TabIndex = 0;

                nameCorrectFlow.Controls.Add(textLabel);
                nameCorrectFlow.Controls.Add(linkLabel);
                nameCorrectFlow.Controls.Add(nameCorrectBtn);
                nameCorrectFlow.Location = new Point(3, 20);
                nameCorrectFlow.Margin = new Padding(3, 0, 3, 0);
                nameCorrectFlow.Name = panelNameBase + i;
                nameCorrectFlow.Size = new Size(271, 20);
                nameCorrectFlow.TabIndex = 1;
                nameCorrectFlow.Visible = false;

                textLabel.Anchor = AnchorStyles.Left;
                textLabel.AutoSize = true;
                textLabel.Location = new Point(0, 3);
                textLabel.Margin = new Padding(0);
                textLabel.Name = "textLabel" + i;
                textLabel.Size = new Size(120, 13);
                textLabel.TabIndex = 0;
                textLabel.Text = "Not found did you mean";
                textLabel.TextAlign = ContentAlignment.MiddleCenter;

                linkLabel.Anchor = AnchorStyles.Left;
                linkLabel.AutoSize = true;
                linkLabel.Location = new Point(120, 3);
                linkLabel.Margin = new Padding(0);
                linkLabel.Name = linkLabelNameBase + i;
                linkLabel.Size = new Size(41, 13);
                linkLabel.TabIndex = 1;
                linkLabel.TabStop = true;
                linkLabel.Text = "[Name]";
                linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(CorrectLinkClicked);

                nameCorrectBtn.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
                nameCorrectBtn.Location = new Point(161, 0);
                nameCorrectBtn.Margin = new Padding(0);
                nameCorrectBtn.Name = buttonNameBase + i;
                nameCorrectBtn.Size = new Size(30, 20);
                nameCorrectBtn.TabIndex = 2;
                nameCorrectBtn.Text = "...";
                nameCorrectBtn.TextAlign = ContentAlignment.TopCenter;
                nameCorrectBtn.UseVisualStyleBackColor = true;
                nameCorrectBtn.Click += new EventHandler(CorrectButtonClicked);

                nameCorrectFlow.ResumeLayout(false);
                nameCorrectFlow.PerformLayout();
                outerFlowLayout.ResumeLayout(false);
                outerFlowLayout.PerformLayout();

                NameTextBoxes.Add(nameTextBox);
                NameCorrectPanels.Add(nameCorrectFlow);
                NameCorrectLinkLabels.Add(linkLabel);
                NameCorrectButtons.Add(nameCorrectBtn);
            }

            redTeamFlow.ResumeLayout(false);
            redTeamFlow.PerformLayout();
            blueTeamFlow.ResumeLayout(false);
            blueTeamFlow.PerformLayout();
        }
    }
}
