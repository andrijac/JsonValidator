using System.Drawing;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace JsonValidator.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnValidateClick(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            this.rtxtResult.Text = this.txtJson.Text;
            this.label1.BackColor = this.BackColor;

            ValidationInfo res = IsValidJson(this.txtJson.Text);

            if (res.IsSuccessful)
            {
                this.label1.Text = "VALID!";
                this.label1.ForeColor = Color.White;
                this.label1.BackColor = Color.Green;
            }
            else
            {
                this.label1.Text = "INVALID!";
                this.label1.ForeColor = Color.White;
                this.label1.BackColor = Color.Red;

                HighlightError(this.rtxtResult, res.Line, res.ByteInLine);
            }

            WriteOutput(res.Message);
        }

        private static ValidationInfo IsValidJson(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return ValidationInfo.Failed("Empty value");
            }

            if (!ValidateBasicStructure(input))
            {
                return ValidationInfo.Failed("JSON value does not start or ends with { or ]");
            }

            try
            {
                var tmpObj = JsonValue.Parse(input);
                return ValidationInfo.Successful();
            }
            catch (FormatException fex)
            {
                return ValidationInfo.Failed(fex.Message);
            }
            catch (System.Text.Json.JsonException jsonex) //some other exception
            {
                return new ValidationInfo(jsonex.Message, jsonex.LineNumber, jsonex.BytePositionInLine, false);
            }
            catch (Exception ex) //some other exception
            {
                return ValidationInfo.Failed(ex.Message);
            }
        }

        private static bool ValidateBasicStructure(string strInput)
        {
            strInput = strInput.Trim();
            return (strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]"));
        }

        private void WriteOutput(string output)
        {
            this.txtOutput.Text = this.txtOutput.Text.Insert(0, $"{output}{Environment.NewLine}");
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private static void HighlightError(RichTextBox richTextBox, long? line, long? position)
        {
            if (!line.HasValue || !position.HasValue)
            {
                return;
            }

            //richTextBox.Focus();
            richTextBox.Select(
                richTextBox.GetFirstCharIndexFromLine((int)line),
                richTextBox.Lines[(int)line - 1].Length);
            richTextBox.SelectionBackColor = Color.Red;

            richTextBox.Select(
               richTextBox.GetFirstCharIndexFromLine((int)line) + (int)position,
               1);
            richTextBox.SelectionBackColor = Color.Yellow;

            richTextBox.Select(0, 0);
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            this.txtOutput.Text = "";
            this.rtxtResult.Text = "";
            this.txtJson.Text = "";
            this.label1.BackColor = this.BackColor;
        }
    }

    internal record ValidationInfo(
            string Message,
            long? Line,
            long? ByteInLine,
            bool IsSuccessful)
    {
        internal static ValidationInfo Successful()
        {
            return new ValidationInfo(string.Empty, null, null, true);
        }

        internal static ValidationInfo Failed(string errorMessage)
        {
            return new ValidationInfo(errorMessage, null, null, false);
        }
    }
}