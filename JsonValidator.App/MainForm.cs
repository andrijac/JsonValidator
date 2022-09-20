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

        public Button BtnValidate => this.btnValidate;

        public RichTextBox TxtJson => this.txtJson;

        public RichTextBox TxtResult => this.txtResult;

        public Button BtnFormat => this.btnFormat;

        public Label LblStatus => this.lblStatus;

        public TextBox TxtOutput => this.txtOutput;

        public Button BtnClearPaste => this.btnClearPaste;

        public Button BtnClear => this.btnClear;
    }
}