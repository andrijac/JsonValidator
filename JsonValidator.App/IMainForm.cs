namespace JsonValidator.App
{
    public interface IMainForm
    {
        Button BtnValidate { get; }
        RichTextBox TxtJson { get; }
        RichTextBox TxtResult { get; }
        Button BtnFormat { get; }
        Label LblStatus { get; }
        TextBox TxtOutput { get; }
        Color BackColor { get; }
        Button BtnClearPaste { get; }
        Button BtnClear { get; }
    }
}