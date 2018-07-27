namespace GoiPlayerProfileDB
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.scanTab = new System.Windows.Forms.TabPage();
            this.previewImageBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileInputText = new System.Windows.Forms.TextBox();
            this.findFileBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.redTeamFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.blueTeamFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.scanBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.scanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.scanTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // scanTab
            // 
            this.scanTab.Controls.Add(this.previewImageBox);
            this.scanTab.Controls.Add(this.flowLayoutPanel1);
            this.scanTab.Location = new System.Drawing.Point(4, 22);
            this.scanTab.Name = "scanTab";
            this.scanTab.Padding = new System.Windows.Forms.Padding(3);
            this.scanTab.Size = new System.Drawing.Size(1032, 651);
            this.scanTab.TabIndex = 0;
            this.scanTab.Text = "Scan";
            this.scanTab.UseVisualStyleBackColor = true;
            // 
            // previewImageBox
            // 
            this.previewImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewImageBox.Location = new System.Drawing.Point(304, 3);
            this.previewImageBox.Name = "previewImageBox";
            this.previewImageBox.Size = new System.Drawing.Size(725, 645);
            this.previewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewImageBox.TabIndex = 2;
            this.previewImageBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 645);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(292, 117);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image File";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.fileInputText);
            this.flowLayoutPanel4.Controls.Add(this.findFileBtn);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(286, 25);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // fileInputText
            // 
            this.fileInputText.Location = new System.Drawing.Point(0, 3);
            this.fileInputText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.fileInputText.Name = "fileInputText";
            this.fileInputText.Size = new System.Drawing.Size(252, 20);
            this.fileInputText.TabIndex = 0;
            this.fileInputText.TextChanged += new System.EventHandler(this.fileInputText_TextChanged);
            // 
            // findFileBtn
            // 
            this.findFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFileBtn.Location = new System.Drawing.Point(252, 3);
            this.findFileBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.findFileBtn.Name = "findFileBtn";
            this.findFileBtn.Size = new System.Drawing.Size(30, 20);
            this.findFileBtn.TabIndex = 1;
            this.findFileBtn.Text = "...";
            this.findFileBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.findFileBtn.UseVisualStyleBackColor = true;
            this.findFileBtn.Click += new System.EventHandler(this.findFileBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(292, 51);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output File";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.outputFileTextBox);
            this.flowLayoutPanel7.Controls.Add(this.saveFileBtn);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(286, 25);
            this.flowLayoutPanel7.TabIndex = 3;
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(0, 3);
            this.outputFileTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(252, 20);
            this.outputFileTextBox.TabIndex = 0;
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileBtn.Location = new System.Drawing.Point(252, 3);
            this.saveFileBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(30, 20);
            this.saveFileBtn.TabIndex = 1;
            this.saveFileBtn.Text = "...";
            this.saveFileBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(3, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 380);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teams";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.tabControl2);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(292, 361);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(286, 360);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.redTeamFlow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(278, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Red Team";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // redTeamFlow
            // 
            this.redTeamFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redTeamFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.redTeamFlow.Location = new System.Drawing.Point(3, 3);
            this.redTeamFlow.Margin = new System.Windows.Forms.Padding(0);
            this.redTeamFlow.Name = "redTeamFlow";
            this.redTeamFlow.Size = new System.Drawing.Size(272, 328);
            this.redTeamFlow.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.blueTeamFlow);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(278, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blue Team";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // blueTeamFlow
            // 
            this.blueTeamFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueTeamFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.blueTeamFlow.Location = new System.Drawing.Point(3, 3);
            this.blueTeamFlow.Name = "blueTeamFlow";
            this.blueTeamFlow.Size = new System.Drawing.Size(272, 328);
            this.blueTeamFlow.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.scanBtn);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 607);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(295, 29);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(3, 3);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(75, 23);
            this.scanBtn.TabIndex = 0;
            this.scanBtn.Text = "Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 677);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.scanTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewImageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage scanTab;
        private System.Windows.Forms.PictureBox previewImageBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox fileInputText;
        private System.Windows.Forms.Button findFileBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel redTeamFlow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel blueTeamFlow;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

