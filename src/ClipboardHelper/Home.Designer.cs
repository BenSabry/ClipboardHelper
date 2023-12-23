namespace ClipboardHelper
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            richTextBox_Content = new RichTextBox();
            label_Message = new Label();
            linkLabel_github = new LinkLabel();
            button_Enabled = new Button();
            button_Reset = new Button();
            SuspendLayout();
            // 
            // richTextBox_Content
            // 
            richTextBox_Content.Location = new Point(12, 12);
            richTextBox_Content.Name = "richTextBox_Content";
            richTextBox_Content.Size = new Size(466, 96);
            richTextBox_Content.TabIndex = 0;
            richTextBox_Content.Text = "TEST Clipboard Helper No. {INCREMENT}/1000";
            richTextBox_Content.TextChanged += richTextBox_Content_TextChanged;
            // 
            // label_Message
            // 
            label_Message.AutoSize = true;
            label_Message.Location = new Point(12, 111);
            label_Message.Name = "label_Message";
            label_Message.Size = new Size(303, 15);
            label_Message.TabIndex = 1;
            label_Message.Text = "Press (KeysCombination) to paste the computed pattern";
            // 
            // linkLabel_github
            // 
            linkLabel_github.AutoSize = true;
            linkLabel_github.Location = new Point(12, 126);
            linkLabel_github.Name = "linkLabel_github";
            linkLabel_github.Size = new Size(96, 15);
            linkLabel_github.TabIndex = 2;
            linkLabel_github.TabStop = true;
            linkLabel_github.Text = "github/BenSabry";
            linkLabel_github.LinkClicked += linkLabel_github_LinkClicked;
            // 
            // button_Enabled
            // 
            button_Enabled.Image = Properties.Resources.play;
            button_Enabled.Location = new Point(398, 111);
            button_Enabled.Name = "button_Enabled";
            button_Enabled.Size = new Size(37, 34);
            button_Enabled.TabIndex = 3;
            button_Enabled.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_Enabled.UseVisualStyleBackColor = true;
            button_Enabled.Click += button_Enabled_Click;
            // 
            // button_Reset
            // 
            button_Reset.Image = Properties.Resources.reset;
            button_Reset.Location = new Point(441, 111);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(37, 34);
            button_Reset.TabIndex = 4;
            button_Reset.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Click += button_Reset_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 150);
            Controls.Add(button_Reset);
            Controls.Add(button_Enabled);
            Controls.Add(linkLabel_github);
            Controls.Add(label_Message);
            Controls.Add(richTextBox_Content);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            Text = "Clipboard Helper";
            FormClosing += Home_FormClosing;
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_Content;
        private Label label_Message;
        private LinkLabel linkLabel_github;
        private Button button_Enabled;
        private Button button1;
        private Button button_Reset;
    }
}
