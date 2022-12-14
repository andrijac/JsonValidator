using JsonValidator.App.Models;

namespace JsonValidator.App
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            _ = new MainFormLogic(this);
        }

        public ToolStripButton BtnValidate => this.tsValidate;

        public ToolStripButton BtnFormat => this.tsFormat;

        public ToolStripButton BtnClearPaste => this.tsClearPaste;

        public ToolStripButton BtnClear => this.tsClear;

        public RichTextBox TxtJson => this.txtJson;

        public RichTextBox TxtResult => this.txtResult;

        public ToolStripStatusLabel LblStatus => this.bottomStatusLabel;

        public TextBox TxtOutput => this.txtOutput;

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new();
            settingsForm.ShowDialog();
        }
    }
}