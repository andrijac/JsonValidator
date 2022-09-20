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

            richTextBox.Select(
               richTextBox.GetFirstCharIndexFromLine((int)line) + (int)position,
               1);
            richTextBox.SelectionBackColor = Color.Yellow;

            richTextBox.Select(0, 0);
        }
    }
}