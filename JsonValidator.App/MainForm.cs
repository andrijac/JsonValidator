namespace JsonValidator.App
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            var formLogic = new MainFormLogic(this);

            formLogic.InitControls();
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
    }
}