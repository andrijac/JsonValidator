using System.Windows.Forms;

namespace JsonValidator.App.Services
{
    public class RichTextBoxService
    {
        public void HighlightError(RichTextBox richTextBox, long? line, long? position)
        {
            if (!line.HasValue || !position.HasValue)
            {
                return;
            }

            //richTextBox.Focus();
            richTextBox.Select(
                richTextBox.GetFirstCharIndexFromLine((int)line),
                richTextBox.Lines[(int)line].Length);
            richTextBox.SelectionBackColor = Color.Red;

            SelectPosition(richTextBox, (int)line, (int)position);

            richTextBox.SelectionBackColor = Color.Yellow;

            richTextBox.Select(0, 0);
        }

        public void ScrollToLine(RichTextBox richTextBox, int line, int position)
        {
            if (line > richTextBox.Lines.Count())
            {
                return;
            }

            SelectPosition(richTextBox, line, position);
            SelectPosition(richTextBox, Math.Max(line - 6, 0), 0);
            richTextBox.ScrollToCaret();
            richTextBox.DeselectAll();
        }

        private static void SelectPosition(RichTextBox richTextBox, int line, int position)
        {
            richTextBox.Select(
               richTextBox.GetFirstCharIndexFromLine((int)line) + (int)position,
               1);
        }
    }
}