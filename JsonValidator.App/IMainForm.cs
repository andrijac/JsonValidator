namespace JsonValidator.App
{
    public interface IMainForm
    {
        ToolStripButton BtnValidate { get; }
        RichTextBox TxtJson { get; }
        RichTextBox TxtResult { get; }
        ToolStripButton BtnFormat { get; }
        ToolStripStatusLabel LblStatus { get; }
        TextBox TxtOutput { get; }
        Color BackColor { get; }
        ToolStripButton BtnClearPaste { get; }
        ToolStripButton BtnClear { get; }
    }
}