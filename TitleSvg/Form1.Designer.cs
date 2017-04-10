namespace TitleSvg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.openFileButton = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.titleBox = new MetroFramework.Controls.MetroTextBox();
            this.changeButton = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.back = new MetroFramework.Controls.MetroButton();
            this.forward = new MetroFramework.Controls.MetroButton();
            this.wikiChangeButton = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.file = new MetroFramework.Controls.MetroLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.wikiLabel = new MetroFramework.Controls.MetroLabel();
            this.linkLabel = new MetroFramework.Controls.MetroLabel();
            this.wikiText = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openFileButton
            // 
            this.openFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFileButton.Location = new System.Drawing.Point(3, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(115, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.openFileButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.flowLayoutPanel1.Controls.Add(this.openFileButton);
            this.flowLayoutPanel1.Controls.Add(this.titleLabel);
            this.flowLayoutPanel1.Controls.Add(this.titleBox);
            this.flowLayoutPanel1.Controls.Add(this.changeButton);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.wikiChangeButton);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(613, 329);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Location = new System.Drawing.Point(3, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 25);
            this.titleLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            this.titleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleLabel.UseStyleColors = true;
            // 
            // titleBox
            // 
            this.titleBox.Enabled = false;
            this.titleBox.Location = new System.Drawing.Point(3, 57);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(115, 23);
            this.titleBox.TabIndex = 2;
            this.titleBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(3, 86);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(115, 23);
            this.changeButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Add Metadata";
            this.changeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.back);
            this.flowLayoutPanel2.Controls.Add(this.forward);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 115);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(116, 39);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // back
            // 
            this.back.Enabled = false;
            this.back.Location = new System.Drawing.Point(0, 3);
            this.back.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(52, 36);
            this.back.TabIndex = 1;
            this.back.Text = "<";
            this.back.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Enabled = false;
            this.forward.Location = new System.Drawing.Point(64, 3);
            this.forward.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(52, 36);
            this.forward.Style = MetroFramework.MetroColorStyle.Blue;
            this.forward.TabIndex = 0;
            this.forward.Text = ">";
            this.forward.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // wikiChangeButton
            // 
            this.wikiChangeButton.Enabled = false;
            this.wikiChangeButton.Location = new System.Drawing.Point(3, 160);
            this.wikiChangeButton.Name = "wikiChangeButton";
            this.wikiChangeButton.Size = new System.Drawing.Size(115, 23);
            this.wikiChangeButton.TabIndex = 13;
            this.wikiChangeButton.Text = "Change Wiki";
            this.wikiChangeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.wikiChangeButton.Click += new System.EventHandler(this.wikiChangeButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.metroLabel1);
            this.flowLayoutPanel3.Controls.Add(this.file);
            this.flowLayoutPanel3.Controls.Add(this.webBrowser1);
            this.flowLayoutPanel3.Controls.Add(this.wikiLabel);
            this.flowLayoutPanel3.Controls.Add(this.linkLabel);
            this.flowLayoutPanel3.Controls.Add(this.wikiText);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(125, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(489, 326);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "File: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.file.Location = new System.Drawing.Point(60, 0);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(0, 0);
            this.file.TabIndex = 1;
            this.file.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.file.UseStyleColors = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(483, 218);
            this.webBrowser1.TabIndex = 4;
            // 
            // wikiLabel
            // 
            this.wikiLabel.AutoSize = true;
            this.wikiLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.wikiLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.wikiLabel.Location = new System.Drawing.Point(3, 249);
            this.wikiLabel.Name = "wikiLabel";
            this.wikiLabel.Size = new System.Drawing.Size(55, 25);
            this.wikiLabel.TabIndex = 10;
            this.wikiLabel.Text = "Wiki:";
            this.wikiLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.wikiLabel.UseStyleColors = true;
            // 
            // linkLabel
            // 
            this.linkLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.linkLabel.Location = new System.Drawing.Point(64, 249);
            this.linkLabel.MinimumSize = new System.Drawing.Size(0, 25);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(0, 25);
            this.linkLabel.TabIndex = 12;
            this.linkLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkLabel.UseStyleColors = true;
            this.linkLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel_MouseClick);
            // 
            // wikiText
            // 
            this.wikiText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.wikiText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wikiText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wikiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wikiText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wikiText.Location = new System.Drawing.Point(3, 277);
            this.wikiText.MaxLength = 475;
            this.wikiText.Name = "wikiText";
            this.wikiText.Size = new System.Drawing.Size(482, 46);
            this.wikiText.TabIndex = 11;
            this.wikiText.Text = "";
            this.wikiText.TextChanged += new System.EventHandler(this.wikiText_TextChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(620, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 409);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Title SVG";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton openFileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox titleBox;
        private MetroFramework.Controls.MetroLabel titleLabel;
        private MetroFramework.Controls.MetroButton changeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroButton forward;
        private MetroFramework.Controls.MetroButton back;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel file;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroLabel wikiLabel;
        private System.Windows.Forms.RichTextBox wikiText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MetroFramework.Controls.MetroLabel linkLabel;
        private MetroFramework.Controls.MetroButton wikiChangeButton;
    }
}

