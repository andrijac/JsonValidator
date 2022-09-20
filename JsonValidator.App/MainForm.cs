using JsonValidator.App.Services;

namespace JsonValidator.App
{
    public partial class MainForm : Form
    {
        private readonly JsonValidatorService jsonValidatorService;
        private readonly RichTextBoxService richTextBoxService;

        public MainForm(
            JsonValidatorService jsonValidatorService,
            RichTextBoxService richTextBoxService)
        {
            InitializeComponent();
            this.jsonValidatorService = jsonValidatorService;
            this.richTextBoxService = richTextBoxService;
        }

        private void BtnValidateClick(object sender, EventArgs e)
        {
            this.ResetBeforeValidate();

            ValidationInfo res = jsonValidatorService.ValidateJson(this.txtJson.Text);

            this.HandleResults(res);

            WriteOutput(res.Message);
        }

        private void HandleResults(ValidationInfo res)
        {
            if (res.IsSuccessful)
            {
                SetStatusLabel("VALID!", Color.White, Color.Green);
            }
            else
            {
                SetStatusLabel("INVALID!", Color.White, Color.Red);
                this.richTextBoxService.HighlightError(this.rtxtResult, res.Line, res.ByteInLine);
            }
        }

        private void SetStatusLabel(
            string text,
            Color foreColor,
            Color backColor)
        {
            this.lblStatus.Text = text;
            this.lblStatus.ForeColor = foreColor;
            this.lblStatus.BackColor = backColor;
        }

        private void WriteOutput(string output)
        {
            this.txtOutput.Text = this.txtOutput.Text.Insert(0, $"{output}{Environment.NewLine}");
        }

        private void BtnClearClick(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void ResetBeforeValidate()
        {
            this.txtOutput.Text = "";
            this.rtxtResult.Text = this.txtJson.Text;
            this.lblStatus.BackColor = this.BackColor;
        }

        private void Clear()
        {
            this.txtOutput.Text = "";
            this.rtxtResult.Text = "";
            this.txtJson.Text = "";
            this.lblStatus.BackColor = this.BackColor;
        }

        private void BtnClearPasteClick(object sender, EventArgs e)
        {
            this.Clear();
            string clipboard = Clipboard.GetText();
            this.txtJson.Text = clipboard;
        }
    }
}