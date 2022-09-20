using JsonValidator.App.Services;

namespace JsonValidator.App
{
    public partial class MainForm : Form
    {
        private readonly JsonValidatorService jsonValidatorService;
        private readonly RichTextBoxService richTextBoxService;
        private readonly JsonFormaterService jsonFormaterService;

        public MainForm(
            JsonValidatorService jsonValidatorService,
            RichTextBoxService richTextBoxService,
            JsonFormaterService jsonFormaterService)
        {
            InitializeComponent();

            SetDropEvents(this);
            SetDropEvents(this.txtJson);
            SetDropEvents(this.rtxtResult);

            this.jsonValidatorService = jsonValidatorService;
            this.richTextBoxService = richTextBoxService;
            this.jsonFormaterService = jsonFormaterService;
        }

        private void SetDropEvents(Control control)
        {
            control.AllowDrop = true;
            control.DragDrop += new DragEventHandler(FormDragDrop);
            control.DragEnter += new DragEventHandler(FormDragEnter);
        }

        private void FormDragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void FormDragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            var file = files.FirstOrDefault();

            if (file == null)
            {
                return;
            }

            var content = File.ReadAllText(file);

            this.txtJson.Text = content;
        }

        private void BtnValidateClick(object sender, EventArgs e)
        {
            this.ResetBeforeValidate();

            ValidationInfo res = jsonValidatorService.ValidateJson(this.txtJson.Text);

            this.HandleResults(res);
        }

        private void HandleResults(ValidationInfo res)
        {
            this.rtxtResult.Text = this.txtJson.Text;

            if (res.IsSuccessful)
            {
                SetStatusLabel("VALID!", Color.White, Color.Green);
            }
            else
            {
                SetStatusLabel("INVALID!", Color.White, Color.Red);
                this.richTextBoxService.HighlightError(this.rtxtResult, res.Line, res.ByteInLine);
            }

            WriteOutput(res.Message);

            this.richTextBoxService.ScrollToLine(
                this.rtxtResult,
                res.Line.HasValue ? (int)res.Line : 0,
                res.ByteInLine.HasValue ? (int)res.ByteInLine : 0);
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
            this.rtxtResult.Text = "";
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

        private void BtnFormatClick(object sender, EventArgs e)
        {
            ResetBeforeValidate();

            (ValidationInfo valInfo, string formatted) = this.jsonFormaterService.FormatJson(this.txtJson.Text);

            if (valInfo.IsSuccessful == false)
            {
                this.HandleResults(valInfo);
                return;
            }

            this.txtJson.Text = formatted;
        }
    }
}