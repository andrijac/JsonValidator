using JsonValidator.App.Models;
using JsonValidator.App.Services;

namespace JsonValidator.App
{
    public class MainFormLogic
    {
        private readonly IMainForm form;
        private readonly JsonValidatorService jsonValidatorService;
        private readonly RichTextBoxService richTextBoxService;
        private readonly JsonFormaterService jsonFormaterService;
        private readonly DragDropService dragDropService;

        public MainFormLogic(
            IMainForm form)
        {
            this.form = form;

            this.jsonValidatorService = new JsonValidatorService();
            this.richTextBoxService = new RichTextBoxService();
            this.jsonFormaterService = new JsonFormaterService(this.jsonValidatorService);
            this.dragDropService = new DragDropService(form);

            this.InitControls();
        }

        private void InitControls()
        {
            this.dragDropService.Init();

            form.BtnValidate.Click += new System.EventHandler(this.BtnValidateClick);
            form.BtnFormat.Click += new System.EventHandler(this.BtnFormatClick);
            form.BtnClearPaste.Click += new System.EventHandler(this.BtnClearPasteClick);
            form.BtnClear.Click += new System.EventHandler(this.BtnClearClick);
        }

        private void HandleResults(ValidationInfo res)
        {
            form.TxtResult.Text = form.TxtJson.Text;

            if (res.IsSuccessful)
            {
                SetStatusLabel("VALID!", Color.White, Color.Green);
            }
            else
            {
                SetStatusLabel("INVALID!", Color.White, Color.Red);
                this.richTextBoxService.HighlightError(form.TxtResult, res.Line, res.ByteInLine);
            }

            WriteOutput(res.Message);

            this.richTextBoxService.ScrollToLine(
                form.TxtResult,
                res.Line.HasValue ? (int)res.Line : 0,
                res.ByteInLine.HasValue ? (int)res.ByteInLine : 0);
        }

        private void SetStatusLabel(
            string text,
            Color foreColor,
            Color backColor)
        {
            form.LblStatus.Text = text;
            form.LblStatus.ForeColor = foreColor;
            form.LblStatus.BackColor = backColor;
        }

        private void WriteOutput(string output)
        {
            form.TxtOutput.Text = form.TxtOutput.Text.Insert(0, $"{output}{Environment.NewLine}");
        }

        private void ResetBeforeValidate()
        {
            form.TxtOutput.Text = "";
            form.TxtResult.Text = "";
            SetStatusLabel("", form.BackColor, form.BackColor);
        }

        private void Clear()
        {
            form.TxtOutput.Text = "";
            form.TxtResult.Text = "";
            form.TxtJson.Text = "";
            SetStatusLabel("", form.BackColor, form.BackColor);
        }

        #region Event handlers

        private void BtnValidateClick(object? sender, EventArgs e)
        {
            this.ResetBeforeValidate();

            ValidationInfo res = jsonValidatorService.ValidateJson(form.TxtJson.Text);

            this.HandleResults(res);
        }

        private void BtnClearClick(object? sender, EventArgs e)
        {
            this.Clear();
        }

        private void BtnClearPasteClick(object? sender, EventArgs e)
        {
            this.Clear();
            string clipboard = Clipboard.GetText();
            form.TxtJson.Text = clipboard;
        }

        private void BtnFormatClick(object? sender, EventArgs e)
        {
            ResetBeforeValidate();

            (ValidationInfo valInfo, string formatted) = this.jsonFormaterService.FormatJson(form.TxtJson.Text);

            if (valInfo.IsSuccessful == false)
            {
                this.HandleResults(valInfo);
                return;
            }

            form.TxtJson.Text = formatted;
        }

        #endregion Event handlers
    }
}