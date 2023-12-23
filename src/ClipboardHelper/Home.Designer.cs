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
            richTextBox_Content = new RichTextBox();
            label_Message = new Label();
            linkLabel_github = new LinkLabel();
            SuspendLayout();
            // 
            // richTextBox_Content
            // 
            richTextBox_Content.Location = new Point(14, 16);
            richTextBox_Content.Margin = new Padding(3, 4, 3, 4);
            richTextBox_Content.Name = "richTextBox_Content";
            richTextBox_Content.Size = new Size(532, 127);
            richTextBox_Content.TabIndex = 0;
            richTextBox_Content.Text = "TEST Clipboard Helper No. {INCREMENT}/1000";
            richTextBox_Content.TextChanged += richTextBox_Content_TextChanged;
            // 
            // label_Message
            // 
            label_Message.AutoSize = true;
            label_Message.Location = new Point(14, 148);
            label_Message.Name = "label_Message";
            label_Message.Size = new Size(379, 20);
            label_Message.TabIndex = 1;
            label_Message.Text = "Press (KeysCombination) to paste the computed pattern";
            // 
            // linkLabel_github
            // 
            linkLabel_github.AutoSize = true;
            linkLabel_github.Location = new Point(437, 148);
            linkLabel_github.Name = "linkLabel_github";
            linkLabel_github.Size = new Size(120, 20);
            linkLabel_github.TabIndex = 2;
            linkLabel_github.TabStop = true;
            linkLabel_github.Text = "github/BenSabry";
            linkLabel_github.LinkClicked += linkLabel_github_LinkClicked;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 177);
            Controls.Add(linkLabel_github);
            Controls.Add(label_Message);
            Controls.Add(richTextBox_Content);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Home";
            Text = "Clipboard Helper";
            FormClosing += Home_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_Content;
        private Label label_Message;
        private LinkLabel linkLabel_github;
    }
}
