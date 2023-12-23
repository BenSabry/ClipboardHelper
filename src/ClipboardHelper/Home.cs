using System.Diagnostics;
using System.Text;

namespace ClipboardHelper
{
    public partial class Home : Form
    {
        #region Properties
        private GlobalKeyboardHook KeyboardHook;
        private Keys[] KeysCombination = [Keys.F12];

        private Settings Settings { get; set; }
        #endregion

        #region Contructors
        public Home()
        {
            InitializeComponent();

            CustomLoad();
        }
        #endregion

        #region Events
        private void linkLabel_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitGithub();
        }
        private void richTextBox_Content_TextChanged(object sender, EventArgs e)
        {
            UpdateContent();
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardHook.Dispose();
        }
        private void KeyboardHook_KeyboardPressed(object? sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
                HotKeyPressed();
        }
        #endregion

        #region Behavior
        private void CustomLoad()
        {
            UpdateDefaultMessage();
            UpdateContent();
            RegisterHotKey();
        }
        private void RegisterHotKey()
        {
            KeyboardHook = new GlobalKeyboardHook(KeysCombination);
            KeyboardHook.KeyboardPressed += KeyboardHook_KeyboardPressed;
        }
        private void UpdateDefaultMessage()
        {
            label_Message.Text = label_Message.Text.Replace(nameof(KeysCombination),
                string.Join(" + ", KeysCombination.Select(k => k.ToString())));
        }
        private void VisitGithub()
        {
            linkLabel_github.LinkVisited = true;
            Process.Start("http://www.microsoft.com");
        }
        private void UpdateContent()
        {
            Settings = new Settings(richTextBox_Content.Text);
        }
        private void HotKeyPressed()
        {
            var clipboard = Clipboard.GetText();
            Clipboard.SetText(Settings.ComputeContent());
            SendKeys.Send(string.Empty);
            SendKeys.SendWait("^{v}");
            Clipboard.SetText(clipboard);
        }
        #endregion
    }
}

class Settings
{
    public string Content { get; private set; }
    public (string Key, string Value, Func<string, string> Compute)[] Pairs { get; private set; }

    public Settings(string content)
    {
        Content = content;

        Pairs =
        [
            ("{INCREMENT}", "0", (s) => (int.Parse(s) + 1).ToString()),

        ];
    }

    public string ComputeContent()
    {
        var sb = new StringBuilder(Content);
        for (int i = 0; i < Pairs.Length; i++)
        {
            Pairs[i].Value = Pairs[i].Compute(Pairs[i].Value);
            sb.Replace(Pairs[i].Key, Pairs[i].Value);
        }

        return sb.ToString();
    }
}
