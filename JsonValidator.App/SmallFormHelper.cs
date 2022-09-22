namespace JsonValidator.App
{
    internal class SmallFormHelper
    {
        internal static void SetProperties(Form form)
        {
            form.MinimumSize = form.Size;
            form.MaximumSize = form.Size;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowInTaskbar = false;
            form.StartPosition = FormStartPosition.CenterParent;
        }
    }
}